namespace LibraryManagementSystem
{
    partial class StudentForm
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
            lblStudentID = new Label();
            lblName = new Label();
            lblDepartment = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtDepartment = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.ForeColor = Color.Olive;
            lblStudentID.Location = new Point(175, 43);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(112, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student_ID : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Olive;
            lblName.Location = new Point(175, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name : ";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.ForeColor = Color.Olive;
            lblDepartment.Location = new Point(175, 199);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(121, 25);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department : ";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(54, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Teal;
            btnUpdate.Location = new Point(231, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Teal;
            btnDelete.Location = new Point(414, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.FromArgb(192, 0, 0);
            btnClear.Location = new Point(604, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(319, 178);
            txtDepartment.Multiline = true;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(226, 46);
            txtDepartment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(319, 96);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 46);
            txtName.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(319, 22);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(226, 46);
            txtStudentID.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(687, 262);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(762, 627);
            Controls.Add(dataGridView1);
            Controls.Add(txtStudentID);
            Controls.Add(txtName);
            Controls.Add(txtDepartment);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblDepartment);
            Controls.Add(lblName);
            Controls.Add(lblStudentID);
            Name = "StudentForm";
            Text = "Manage Student";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblName;
        private Label lblDepartment;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtDepartment;
        private TextBox txtName;
        private TextBox txtStudentID;
        private DataGridView dataGridView1;
    }
}