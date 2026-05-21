namespace LibraryManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(200, 341);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(213, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Library Management System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Purple;
            lblUsername.Location = new Point(149, 111);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Purple;
            lblPassword.Location = new Point(152, 222);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 219);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 46);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(277, 108);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 46);
            txtUsername.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(480, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnExit;
    }
}
