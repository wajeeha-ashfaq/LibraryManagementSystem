namespace LibraryManagementSystem
{
    partial class BookForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblBookID = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblQuantity = new Label();
            dataGridView1 = new DataGridView();
            txtBookID = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(101, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Purple;
            btnUpdate.Location = new Point(328, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(556, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Purple;
            btnClear.Location = new Point(784, 264);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.ForeColor = Color.FromArgb(128, 64, 64);
            lblBookID.Location = new Point(46, 48);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(87, 25);
            lblBookID.TabIndex = 4;
            lblBookID.Text = "Book_ID :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.FromArgb(128, 64, 64);
            lblTitle.Location = new Point(582, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(53, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.ForeColor = Color.FromArgb(128, 64, 64);
            lblAuthor.Location = new Point(46, 159);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(76, 25);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author :";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.ForeColor = Color.FromArgb(128, 64, 64);
            lblQuantity.Location = new Point(579, 159);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(89, 25);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 357);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(795, 276);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(219, 45);
            txtBookID.Multiline = true;
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(197, 46);
            txtBookID.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(707, 45);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(189, 46);
            txtTitle.TabIndex = 10;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(219, 156);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(197, 46);
            txtAuthor.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(707, 156);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(189, 46);
            txtQuantity.TabIndex = 12;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1002, 656);
            Controls.Add(txtQuantity);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtBookID);
            Controls.Add(dataGridView1);
            Controls.Add(lblQuantity);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblBookID);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "BookForm";
            Text = "Manage Books";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblBookID;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblQuantity;
        private DataGridView dataGridView1;
        private TextBox txtBookID;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtQuantity;
    }
}