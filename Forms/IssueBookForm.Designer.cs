namespace LibraryManagementSystem.Forms
{
    partial class IssueBookForm
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
            btnIssue = new Button();
            cmbBook = new ComboBox();
            cmbStudent = new ComboBox();
            dtpIssueDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            lblBook = new Label();
            lblStudent = new Label();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnIssue
            // 
            btnIssue.ForeColor = Color.DeepPink;
            btnIssue.Location = new Point(258, 487);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(112, 34);
            btnIssue.TabIndex = 0;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(309, 25);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(182, 33);
            cmbBook.TabIndex = 1;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(309, 88);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(182, 33);
            cmbStudent.TabIndex = 2;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.CalendarForeColor = Color.Purple;
            dtpIssueDate.CalendarTrailingForeColor = Color.Maroon;
            dtpIssueDate.Format = DateTimePickerFormat.Short;
            dtpIssueDate.Location = new Point(309, 153);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(182, 31);
            dtpIssueDate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(632, 225);
            dataGridView1.TabIndex = 4;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.ForeColor = Color.DeepPink;
            lblBook.Location = new Point(150, 33);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(118, 25);
            lblBook.TabIndex = 5;
            lblBook.Text = "Select Book : ";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.ForeColor = Color.DeepPink;
            lblStudent.Location = new Point(150, 96);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(133, 25);
            lblStudent.TabIndex = 6;
            lblStudent.Text = "Select Student :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.DeepPink;
            lblDate.Location = new Point(150, 159);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 25);
            lblDate.TabIndex = 7;
            lblDate.Text = "Issue Date : ";
            // 
            // IssueBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(656, 560);
            Controls.Add(lblDate);
            Controls.Add(lblStudent);
            Controls.Add(lblBook);
            Controls.Add(dataGridView1);
            Controls.Add(dtpIssueDate);
            Controls.Add(cmbStudent);
            Controls.Add(cmbBook);
            Controls.Add(btnIssue);
            Name = "IssueBookForm";
            Text = "Issue Book";
            Load += IssueBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIssue;
        private ComboBox cmbBook;
        private ComboBox cmbStudent;
        private DateTimePicker dtpIssueDate;
        private DataGridView dataGridView1;
        private Label lblBook;
        private Label lblStudent;
        private Label lblDate;
    }
}