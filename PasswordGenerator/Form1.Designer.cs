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
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnCopy = new Button();
            btnSave = new Button();
            numericLength = new NumericUpDown();
            chkUpper = new CheckBox();
            chkLower = new CheckBox();
            chkNumbers = new CheckBox();
            chkSymbols = new CheckBox();
            label1 = new Label();
            listSaved = new ListBox();
            labelSaved = new Label();
            txtAccount = new TextBox();
            labelAccount = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(20, 260);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(120, 260);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // numericLength
            // 
            numericLength.Location = new Point(150, 110);
            numericLength.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numericLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericLength.Name = "numericLength";
            numericLength.Size = new Size(120, 23);
            numericLength.TabIndex = 4;
            numericLength.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // chkUpper
            // 
            chkUpper.Location = new Point(20, 140);
            chkUpper.Name = "chkUpper";
            chkUpper.Size = new Size(104, 24);
            chkUpper.TabIndex = 5;
            chkUpper.Text = "Uppercase (A-Z)";
            // 
            // chkLower
            // 
            chkLower.Checked = true;
            chkLower.CheckState = CheckState.Checked;
            chkLower.Location = new Point(20, 170);
            chkLower.Name = "chkLower";
            chkLower.Size = new Size(104, 24);
            chkLower.TabIndex = 6;
            chkLower.Text = "Lowercase (a-z)";
            // 
            // chkNumbers
            // 
            chkNumbers.Location = new Point(20, 200);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(104, 24);
            chkNumbers.TabIndex = 7;
            chkNumbers.Text = "Numbers (0-9)";
            // 
            // chkSymbols
            // 
            chkSymbols.Location = new Point(20, 230);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(104, 24);
            chkSymbols.TabIndex = 8;
            chkSymbols.Text = "Symbols (!@#)";
            // 
            // label1
            // 
            label1.Location = new Point(20, 110);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Password Length";
            // 
            // listSaved
            // 
            listSaved.Location = new Point(320, 50);
            listSaved.Name = "listSaved";
            listSaved.Size = new Size(200, 244);
            listSaved.TabIndex = 10;
            listSaved.DoubleClick += listSaved_DoubleClick;
            // 
            // labelSaved
            // 
            labelSaved.Location = new Point(320, 20);
            labelSaved.Name = "labelSaved";
            labelSaved.Size = new Size(191, 23);
            labelSaved.TabIndex = 11;
            labelSaved.Text = "Saved Passwords";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(77, 50);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(183, 23);
            txtAccount.TabIndex = 12;
            // 
            // labelAccount
            // 
            labelAccount.Location = new Point(20, 50);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(100, 23);
            labelAccount.TabIndex = 13;
            labelAccount.Text = "Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 297);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 14;
            label2.Text = "By Kara";
            // 
            // Form1
            // 
            ClientSize = new Size(550, 320);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnGenerate);
            Controls.Add(btnCopy);
            Controls.Add(btnSave);
            Controls.Add(numericLength);
            Controls.Add(chkUpper);
            Controls.Add(chkLower);
            Controls.Add(chkNumbers);
            Controls.Add(chkSymbols);
            Controls.Add(label1);
            Controls.Add(listSaved);
            Controls.Add(labelSaved);
            Controls.Add(txtAccount);
            Controls.Add(labelAccount);
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
    }
}