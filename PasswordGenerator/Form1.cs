using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        // Store real passwords in memory
        Dictionary<string, string> savedPasswords = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;

            string chars = "";

            if (chkUpper.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (chkLower.Checked)
                chars += "abcdefghijklmnopqrstuvwxyz";

            if (chkNumbers.Checked)
                chars += "0123456789";

            if (chkSymbols.Checked)
                chars += "!@#$%^&*()_-+=<>?";

            if (chars.Length == 0)
            {
                MessageBox.Show("Select at least one option!");
                return;
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                password.Append(chars[index]);
            }

            txtPassword.Text = password.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Password copied!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Generate a password first!");
                return;
            }

            string account = txtAccount.Text.Trim();

            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("Enter account name (example: Instagram)");
                return;
            }

            string password = txtPassword.Text;

            // Save password in dictionary
            savedPasswords[account] = password;

            // Masked password
            string hidden = new string('*', password.Length);

            listSaved.Items.Add(account + " - " + hidden);

            txtAccount.Clear();
        }

        private void listSaved_DoubleClick(object sender, EventArgs e)
        {
            if (listSaved.SelectedItem == null)
                return;

            string selected = listSaved.SelectedItem.ToString();
            string account = selected.Split('-')[0].Trim();

            if (savedPasswords.ContainsKey(account))
            {
                string realPassword = savedPasswords[account];

                MessageBox.Show(
                    "Account: " + account +
                    "\nPassword: " + realPassword,
                    "Saved Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}