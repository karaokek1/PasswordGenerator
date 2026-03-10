namespace PasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupChar;
        private System.Windows.Forms.GroupBox groupDiceware;
        private System.Windows.Forms.Button btnGenerateChar;
        private System.Windows.Forms.Button btnGenerateDiceware;
        private System.Windows.Forms.Button btnCopyChar;
        private System.Windows.Forms.Button btnCopyDiceware;
        private System.Windows.Forms.TextBox txtCharPassword;
        private System.Windows.Forms.TextBox txtDicewarePassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.ListBox listSaved;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.PictureBox picDiceChar;
        private System.Windows.Forms.Label lblWuerfeln;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupChar = new System.Windows.Forms.GroupBox();
            this.groupDiceware = new System.Windows.Forms.GroupBox();
            this.btnGenerateChar = new System.Windows.Forms.Button();
            this.btnGenerateDiceware = new System.Windows.Forms.Button();
            this.btnCopyChar = new System.Windows.Forms.Button();
            this.btnCopyDiceware = new System.Windows.Forms.Button();
            this.txtCharPassword = new System.Windows.Forms.TextBox();
            this.txtDicewarePassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.listSaved = new System.Windows.Forms.ListBox();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.picDiceChar = new System.Windows.Forms.PictureBox();
            this.lblWuerfeln = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceChar)).BeginInit();
            this.SuspendLayout();

            // 
            // groupChar
            // 
            this.groupChar.Text = "Character-based Password";
            this.groupChar.Location = new System.Drawing.Point(12, 12);
            this.groupChar.Size = new System.Drawing.Size(350, 160);
            this.groupChar.Controls.Add(this.txtCharPassword);
            this.groupChar.Controls.Add(this.btnGenerateChar);
            this.groupChar.Controls.Add(this.btnCopyChar);
            this.groupChar.Controls.Add(this.picDiceChar);

            // 
            // txtCharPassword
            // 
            this.txtCharPassword.Location = new System.Drawing.Point(15, 30);
            this.txtCharPassword.Size = new System.Drawing.Size(320, 22);
            this.txtCharPassword.ReadOnly = true;

            // 
            // btnGenerateChar
            // 
            this.btnGenerateChar.Location = new System.Drawing.Point(15, 60);
            this.btnGenerateChar.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateChar.Text = "Generate Char Password";
            this.btnGenerateChar.Click += new System.EventHandler(this.btnGenerateChar_Click);

            // 
            // btnCopyChar
            // 
            this.btnCopyChar.Location = new System.Drawing.Point(185, 60);
            this.btnCopyChar.Size = new System.Drawing.Size(150, 30);
            this.btnCopyChar.Text = "Copy";
            this.btnCopyChar.Click += new System.EventHandler(this.btnCopyChar_Click);

            // 
            // picDiceChar
            // 
            this.picDiceChar.Location = new System.Drawing.Point(15, 100);
            this.picDiceChar.Size = new System.Drawing.Size(32, 32);
            this.picDiceChar.Visible = false;

            // 
            // groupDiceware
            // 
            this.groupDiceware.Text = "Diceware Passphrase";
            this.groupDiceware.Location = new System.Drawing.Point(12, 180);
            this.groupDiceware.Size = new System.Drawing.Size(350, 200);
            this.groupDiceware.Controls.Add(this.txtDicewarePassword);
            this.groupDiceware.Controls.Add(this.btnGenerateDiceware);
            this.groupDiceware.Controls.Add(this.btnCopyDiceware);
            this.groupDiceware.Controls.Add(this.picDice);
            this.groupDiceware.Controls.Add(this.lblWuerfeln);

            // 
            // txtDicewarePassword
            // 
            this.txtDicewarePassword.Location = new System.Drawing.Point(15, 30);
            this.txtDicewarePassword.Size = new System.Drawing.Size(320, 22);
            this.txtDicewarePassword.ReadOnly = true;

            // 
            // btnGenerateDiceware
            // 
            this.btnGenerateDiceware.Location = new System.Drawing.Point(15, 60);
            this.btnGenerateDiceware.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateDiceware.Text = "Generate Diceware";
            this.btnGenerateDiceware.Click += new System.EventHandler(this.btnGenerateDiceware_Click);

            // 
            // btnCopyDiceware
            // 
            this.btnCopyDiceware.Location = new System.Drawing.Point(185, 60);
            this.btnCopyDiceware.Size = new System.Drawing.Size(150, 30);
            this.btnCopyDiceware.Text = "Copy";
            this.btnCopyDiceware.Click += new System.EventHandler(this.btnCopyDiceware_Click);

            // 
            // picDice
            // 
            this.picDice.Location = new System.Drawing.Point(15, 100);
            this.picDice.Size = new System.Drawing.Size(32, 32);
            this.picDice.Visible = false;

            // 
            // lblWuerfeln
            // 
            this.lblWuerfeln.Location = new System.Drawing.Point(55, 105);
            this.lblWuerfeln.Size = new System.Drawing.Size(150, 25);
            this.lblWuerfeln.Text = "Rolling Dice...";
            this.lblWuerfeln.Visible = false;

            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(380, 30);
            this.numericLength.Minimum = 1;
            this.numericLength.Maximum = 20;
            this.numericLength.Value = 8;
            this.numericLength.Size = new System.Drawing.Size(60, 22);

            // 
            // Checkboxes
            // 
            this.chkUpper.Location = new System.Drawing.Point(380, 70);
            this.chkUpper.Text = "Uppercase";
            this.chkLower.Location = new System.Drawing.Point(380, 100);
            this.chkLower.Text = "Lowercase";
            this.chkNumbers.Location = new System.Drawing.Point(380, 130);
            this.chkNumbers.Text = "Numbers";
            this.chkSymbols.Location = new System.Drawing.Point(380, 160);
            this.chkSymbols.Text = "Symbols";

            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(12, 400);
            this.txtAccount.Size = new System.Drawing.Size(200, 22);
            this.txtAccount.PlaceholderText = "Account Name";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 398);
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // listSaved
            // 
            this.listSaved.Location = new System.Drawing.Point(12, 430);
            this.listSaved.Size = new System.Drawing.Size(350, 150);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.groupChar);
            this.Controls.Add(this.groupDiceware);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listSaved);
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}