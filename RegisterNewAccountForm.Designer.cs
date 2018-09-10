namespace Quiz
{
    partial class RegisterNewAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(222, 12);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(226, 26);
            this.fullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password -";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(222, 44);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(226, 26);
            this.password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password (confirmation) -";
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(222, 76);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.PasswordChar = '*';
            this.passwordConfirm.Size = new System.Drawing.Size(226, 26);
            this.passwordConfirm.TabIndex = 8;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth.Location = new System.Drawing.Point(307, 124);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(141, 26);
            this.dateOfBirth.TabIndex = 10;
            this.dateOfBirth.Value = new System.DateTime(2002, 9, 1, 15, 58, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date of Birth -";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(18, 173);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(121, 38);
            this.BtnRegister.TabIndex = 14;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RegisterNewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 234);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullName);
            this.Name = "RegisterNewAccountForm";
            this.Text = "Register New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegister;
    }
}