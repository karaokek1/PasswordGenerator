using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Drawing;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Dictionary<string, string> savedPasswords = new Dictionary<string, string>();
        Dictionary<string, string> dicewareWords = new Dictionary<string, string>();

        string filePath = "passwords.txt";
        string symbols = "!@#$%^&*()-_=+[]{}";

        private string charPassword = "";
        private string dicewarePassword = "";

        public Form1()
        {
            InitializeComponent();
            LoadPasswords();
            LoadDiceware();
            LoadDiceGifs();

            // Event for copying saved password
            listSaved.DoubleClick += listSaved_DoubleClick;
        }

        #region GIF Loading
        private void LoadDiceGifs()
        {
            string dicewareGif = Path.Combine(Application.StartupPath, "dice.gif");
            string charDiceGif = Path.Combine(Application.StartupPath, "dice_char.gif");

            if (File.Exists(dicewareGif))
            {
                picDice.Image = Image.FromFile(dicewareGif);
                ImageAnimator.Animate(picDice.Image, (s, e) => picDice.Invalidate());
            }

            if (File.Exists(charDiceGif))
            {
                picDiceChar.Image = Image.FromFile(charDiceGif);
                ImageAnimator.Animate(picDiceChar.Image, (s, e) => picDiceChar.Invalidate());
            }
        }
        #endregion

        #region Diceware
        private void LoadDiceware()
        {
            try
            {
                string dicewarePath = Path.Combine(Application.StartupPath, "diceware.txt");
                if (!File.Exists(dicewarePath))
                {
                    MessageBox.Show("diceware.txt not found!");
                    return;
                }

                dicewareWords.Clear();
                foreach (string line in File.ReadAllLines(dicewarePath))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        string key = parts[0].Trim();
                        string word = parts[1].Trim();
                        if (!dicewareWords.ContainsKey(key)) dicewareWords.Add(key, word);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading diceware.txt: " + ex.Message);
            }
        }

        private int RollDie() => RandomNumberGenerator.GetInt32(1, 7);

        private string RollDiceKey()
        {
            string key = "";
            for (int i = 0; i < 5; i++) key += RollDie();
            return key;
        }

        private string GenerateDicewarePassphrase(int wordCount, bool addUpper, bool addLower, bool addNumbers, bool addSymbols)
        {
            List<string> words = new List<string>();
            for (int i = 0; i < wordCount; i++)
            {
                string key = RollDiceKey();
                if (dicewareWords.ContainsKey(key)) words.Add(dicewareWords[key]);
                else i--; // retry
            }

            string pass = string.Join("-", words);

            if (addUpper) pass = pass.ToUpper();
            if (addLower) pass = pass.ToLower();
            if (addNumbers) pass += RandomNumberGenerator.GetInt32(0, 1000);
            if (addSymbols) pass += symbols[RandomNumberGenerator.GetInt32(0, symbols.Length)];

            return pass;
        }

        private async void btnGenerateDiceware_Click(object sender, EventArgs e)
        {
            if (dicewareWords.Count == 0)
            {
                MessageBox.Show("Diceware list not loaded!");
                return;
            }

            picDice.Visible = true;
            lblWuerfeln.Visible = true;
            btnGenerateDiceware.Enabled = false;

            await Task.Delay(1500);

            int words = (int)numericLength.Value;
            dicewarePassword = GenerateDicewarePassphrase(words,
                chkUpper.Checked, chkLower.Checked, chkNumbers.Checked, chkSymbols.Checked);

            txtDicewarePassword.Text = dicewarePassword;

            picDice.Visible = false;
            lblWuerfeln.Visible = false;
            btnGenerateDiceware.Enabled = true;
        }
        #endregion

        #region Character-based password
        private async void btnGenerateChar_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;
            string chars = "";
            if (chkUpper.Checked) chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (chkLower.Checked) chars += "abcdefghijklmnopqrstuvwxyz";
            if (chkNumbers.Checked) chars += "0123456789";
            if (chkSymbols.Checked) chars += "!@#$%^&*()_-+=<>?";

            if (string.IsNullOrEmpty(chars))
            {
                MessageBox.Show("Select at least one option!");
                return;
            }

            picDiceChar.Visible = true;
            await Task.Delay(500);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(chars[rnd.Next(chars.Length)]);

            charPassword = sb.ToString();
            txtCharPassword.Text = charPassword;

            picDiceChar.Visible = false;
        }
        #endregion

        #region Copy Buttons
        private void btnCopyChar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(charPassword))
            {
                Clipboard.SetText(charPassword);
                MessageBox.Show("Character password copied!");
            }
        }

        private void btnCopyDiceware_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dicewarePassword))
            {
                Clipboard.SetText(dicewarePassword);
                MessageBox.Show("Diceware password copied!");
            }
        }
        #endregion

        #region Save & Load
        private void btnSave_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("Enter account name!");
                return;
            }

            string password = txtCharPassword.Text.Length > 0 ? charPassword : dicewarePassword;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Generate a password first!");
                return;
            }

            savedPasswords[account] = password;
            listSaved.Items.Add(account + " - " + new string('*', password.Length));
            SavePasswords();
            txtAccount.Clear();
        }

        private void SavePasswords()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var kv in savedPasswords)
                    sw.WriteLine($"{kv.Key}|{kv.Value}");
            }
        }

        private void LoadPasswords()
        {
            if (!File.Exists(filePath)) return;
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    savedPasswords[parts[0]] = parts[1];
                    listSaved.Items.Add(parts[0] + " - " + new string('*', parts[1].Length));
                }
            }
        }
        #endregion

        #region Copy Saved Password on Click
        private void listSaved_DoubleClick(object sender, EventArgs e)
        {
            if (listSaved.SelectedItem == null) return;

            string account = listSaved.SelectedItem.ToString().Split('-')[0].Trim();
            if (savedPasswords.ContainsKey(account))
            {
                string password = savedPasswords[account];
                Clipboard.SetText(password);
                MessageBox.Show($"Password for '{account}' copied!");
            }
        }
        #endregion
    }
}