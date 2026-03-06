namespace PasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSaved;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label labelAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listSaved = new System.Windows.Forms.ListBox();
            this.labelSaved = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            this.SuspendLayout();

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 80);
            this.txtPassword.Size = new System.Drawing.Size(240, 23);

            // labelAccount
            this.labelAccount.Text = "Account";
            this.labelAccount.Location = new System.Drawing.Point(20, 50);

            // txtAccount
            this.txtAccount.Location = new System.Drawing.Point(100, 50);
            this.txtAccount.Size = new System.Drawing.Size(160, 23);

            // label1 (Password Length)
            this.label1.Text = "Password Length";
            this.label1.Location = new System.Drawing.Point(20, 110);

            // numericLength
            this.numericLength.Location = new System.Drawing.Point(150, 110);
            this.numericLength.Minimum = 4;
            this.numericLength.Maximum = 64;
            this.numericLength.Value = 12;

            // chkUpper
            this.chkUpper.Text = "Uppercase (A-Z)";
            this.chkUpper.Location = new System.Drawing.Point(20, 140);

            // chkLower
            this.chkLower.Text = "Lowercase (a-z)";
            this.chkLower.Location = new System.Drawing.Point(20, 170);
            this.chkLower.Checked = true;

            // chkNumbers
            this.chkNumbers.Text = "Numbers (0-9)";
            this.chkNumbers.Location = new System.Drawing.Point(20, 200);

            // chkSymbols
            this.chkSymbols.Text = "Symbols (!@#)";
            this.chkSymbols.Location = new System.Drawing.Point(20, 230);

            // btnGenerate
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Location = new System.Drawing.Point(20, 260);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // btnCopy
            this.btnCopy.Text = "Copy";
            this.btnCopy.Location = new System.Drawing.Point(120, 260);
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(200, 260);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // labelSaved
            this.labelSaved.Text = "Saved Passwords";
            this.labelSaved.Location = new System.Drawing.Point(320, 20);

            // listSaved
            this.listSaved.Location = new System.Drawing.Point(320, 50);
            this.listSaved.Size = new System.Drawing.Size(200, 250);
            this.listSaved.DoubleClick += new System.EventHandler(this.listSaved_DoubleClick);

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSaved);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.labelAccount);

            this.Text = "Password Generator";

            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}