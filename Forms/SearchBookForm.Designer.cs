namespace LibraryManagementSystem.Forms
{
    partial class SearchBookForm
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
            btnSearch = new Button();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.ForeColor = Color.FromArgb(255, 128, 0);
            btnSearch.Location = new Point(298, 393);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Book";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(255, 128, 0);
            lblSearch.Location = new Point(161, 79);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(156, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Book Title :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(348, 76);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(255, 46);
            txtSearch.TabIndex = 3;
            // 
            // SearchBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(lblSearch);
            Controls.Add(btnSearch);
            Name = "SearchBookForm";
            Text = "Search Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
    }
}