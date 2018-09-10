namespace Quiz
{
    partial class ReportForm
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
            this.GenerateReport = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateReport
            // 
            this.GenerateReport.Location = new System.Drawing.Point(16, 69);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(251, 42);
            this.GenerateReport.TabIndex = 0;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(103, 25);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(164, 26);
            this.usernameField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // ReportTable
            // 
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.YearGroupColumn,
            this.TopicColumn,
            this.ScoreColumn,
            this.DifficultyColumn});
            this.ReportTable.Location = new System.Drawing.Point(299, 25);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.RowTemplate.Height = 28;
            this.ReportTable.Size = new System.Drawing.Size(815, 450);
            this.ReportTable.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Student Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // YearGroupColumn
            // 
            this.YearGroupColumn.HeaderText = "Year Group";
            this.YearGroupColumn.Name = "YearGroupColumn";
            this.YearGroupColumn.ReadOnly = true;
            // 
            // TopicColumn
            // 
            this.TopicColumn.HeaderText = "Topic";
            this.TopicColumn.Name = "TopicColumn";
            this.TopicColumn.ReadOnly = true;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            // 
            // DifficultyColumn
            // 
            this.DifficultyColumn.HeaderText = "Difficulty";
            this.DifficultyColumn.Name = "DifficultyColumn";
            this.DifficultyColumn.ReadOnly = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 490);
            this.Controls.Add(this.ReportTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.GenerateReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ReportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyColumn;
    }
}