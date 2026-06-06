namespace LibraryManagementSystem.Forms
{
    partial class Dashboard
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
            btnManageBook = new Button();
            btnManageStudent = new Button();
            btnSearchBook = new Button();
            btnIssueBook = new Button();
            btnReturnBook = new Button();
            btnLogout = new Button();
            lblTitle = new Label();
            lblDashboard = new Label();
            SuspendLayout();
            // 
            // btnManageBook
            // 
            btnManageBook.ForeColor = Color.Purple;
            btnManageBook.Location = new Point(152, 156);
            btnManageBook.Name = "btnManageBook";
            btnManageBook.Size = new Size(149, 34);
            btnManageBook.TabIndex = 0;
            btnManageBook.Text = "Manage Books";
            btnManageBook.UseVisualStyleBackColor = true;
            btnManageBook.Click += btnManageBook_Click;
            // 
            // btnManageStudent
            // 
            btnManageStudent.ForeColor = Color.Purple;
            btnManageStudent.Location = new Point(478, 156);
            btnManageStudent.Name = "btnManageStudent";
            btnManageStudent.Size = new Size(176, 34);
            btnManageStudent.TabIndex = 1;
            btnManageStudent.Text = "Manage Students ";
            btnManageStudent.UseVisualStyleBackColor = true;
            btnManageStudent.Click += btnManageStudent_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.ForeColor = Color.Purple;
            btnSearchBook.Location = new Point(152, 261);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(149, 34);
            btnSearchBook.TabIndex = 2;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnIssueBook
            // 
            btnIssueBook.ForeColor = Color.Purple;
            btnIssueBook.Location = new Point(478, 261);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(176, 34);
            btnIssueBook.TabIndex = 3;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.ForeColor = Color.Purple;
            btnReturnBook.Location = new Point(152, 376);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(149, 34);
            btnReturnBook.TabIndex = 4;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.Location = new Point(478, 376);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(176, 34);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(216, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 32);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Library Management System";
            lblTitle.Click += label1_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.FromArgb(0, 192, 192);
            lblDashboard.Location = new Point(327, 88);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(132, 32);
            lblDashboard.TabIndex = 7;
            lblDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDashboard);
            Controls.Add(lblTitle);
            Controls.Add(btnLogout);
            Controls.Add(btnReturnBook);
            Controls.Add(btnIssueBook);
            Controls.Add(btnSearchBook);
            Controls.Add(btnManageStudent);
            Controls.Add(btnManageBook);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageBook;
        private Button btnManageStudent;
        private Button btnSearchBook;
        private Button btnIssueBook;
        private Button btnReturnBook;
        private Button btnLogout;
        private Label lblTitle;
        private Label lblDashboard;
    }
}