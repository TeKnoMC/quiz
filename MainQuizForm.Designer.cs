namespace Quiz
{
    partial class MainQuizForm
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.qBox = new System.Windows.Forms.TextBox();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.drpdwnDifficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpdwnSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateUserReport = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.pnlRadioButtons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(38, 464);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(141, 30);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start Quiz";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(38, 53);
            this.qBox.Multiline = true;
            this.qBox.Name = "qBox";
            this.qBox.ReadOnly = true;
            this.qBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qBox.Size = new System.Drawing.Size(508, 271);
            this.qBox.TabIndex = 1;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Location = new System.Drawing.Point(0, 17);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(126, 24);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "radioButton1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.Visible = false;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Location = new System.Drawing.Point(0, 107);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(126, 24);
            this.rbAnswer4.TabIndex = 3;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "radioButton4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.Visible = false;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(0, 77);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(126, 24);
            this.rbAnswer3.TabIndex = 4;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "radioButton3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.Visible = false;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(0, 47);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(126, 24);
            this.rbAnswer2.TabIndex = 5;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "radioButton2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.Visible = false;
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(567, 232);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(141, 30);
            this.BtnAnswer.TabIndex = 6;
            this.BtnAnswer.Text = "Answer";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Visible = false;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Controls.Add(this.rbAnswer1);
            this.pnlRadioButtons.Controls.Add(this.rbAnswer2);
            this.pnlRadioButtons.Controls.Add(this.rbAnswer4);
            this.pnlRadioButtons.Controls.Add(this.rbAnswer3);
            this.pnlRadioButtons.Location = new System.Drawing.Point(567, 53);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(598, 173);
            this.pnlRadioButtons.TabIndex = 7;
            // 
            // drpdwnDifficulty
            // 
            this.drpdwnDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnDifficulty.FormattingEnabled = true;
            this.drpdwnDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.drpdwnDifficulty.Location = new System.Drawing.Point(38, 377);
            this.drpdwnDifficulty.Name = "drpdwnDifficulty";
            this.drpdwnDifficulty.Size = new System.Drawing.Size(173, 28);
            this.drpdwnDifficulty.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select difficulty:";
            // 
            // drpdwnSubject
            // 
            this.drpdwnSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdwnSubject.FormattingEnabled = true;
            this.drpdwnSubject.Items.AddRange(new object[] {
            "Computer Science",
            "History",
            "Music"});
            this.drpdwnSubject.Location = new System.Drawing.Point(217, 377);
            this.drpdwnSubject.Name = "drpdwnSubject";
            this.drpdwnSubject.Size = new System.Drawing.Size(173, 28);
            this.drpdwnSubject.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select subject:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.TeacherMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1179, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SwitchUser});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // SwitchUser
            // 
            this.SwitchUser.Name = "SwitchUser";
            this.SwitchUser.Size = new System.Drawing.Size(210, 30);
            this.SwitchUser.Text = "Switch user ";
            this.SwitchUser.Click += new System.EventHandler(this.SwitchUser_Click);
            // 
            // TeacherMenu
            // 
            this.TeacherMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateUserReport});
            this.TeacherMenu.Enabled = false;
            this.TeacherMenu.Name = "TeacherMenu";
            this.TeacherMenu.Size = new System.Drawing.Size(82, 29);
            this.TeacherMenu.Text = "Teacher";
            this.TeacherMenu.Visible = false;
            // 
            // GenerateUserReport
            // 
            this.GenerateUserReport.Name = "GenerateUserReport";
            this.GenerateUserReport.Size = new System.Drawing.Size(258, 30);
            this.GenerateUserReport.Text = "Generate user report";
            this.GenerateUserReport.Click += new System.EventHandler(this.GenerateUserReport_Click);
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Location = new System.Drawing.Point(34, 13);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(113, 20);
            this.currentUserLbl.TabIndex = 13;
            this.currentUserLbl.Text = "Logged in as - ";
            // 
            // MainQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 540);
            this.Controls.Add(this.currentUserLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpdwnSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpdwnDifficulty);
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainQuizForm";
            this.Text = "Quiz";
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.Button BtnAnswer;
        private System.Windows.Forms.Panel pnlRadioButtons;
        private System.Windows.Forms.ComboBox drpdwnDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpdwnSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SwitchUser;
        private System.Windows.Forms.ToolStripMenuItem TeacherMenu;
        private System.Windows.Forms.ToolStripMenuItem GenerateUserReport;
        private System.Windows.Forms.Label currentUserLbl;
    }
}

