namespace LibraryManagementSystem.Forms
{
    partial class ReturnBookForm
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
            btnReturn = new Button();
            cmbIssueID = new ComboBox();
            dataGridView1 = new DataGridView();
            dtpReturnDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtFine = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.ForeColor = Color.Maroon;
            btnReturn.Location = new Point(465, 428);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(153, 34);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cmbIssueID
            // 
            cmbIssueID.FormattingEnabled = true;
            cmbIssueID.Location = new Point(465, 12);
            cmbIssueID.Name = "cmbIssueID";
            cmbIssueID.Size = new Size(269, 33);
            cmbIssueID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1008, 225);
            dataGridView1.TabIndex = 2;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(465, 67);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(269, 31);
            dtpReturnDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Issue_ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(297, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 5;
            label2.Text = "Return Date :";
            // 
            // txtFine
            // 
            txtFine.AutoSize = true;
            txtFine.ForeColor = Color.Firebrick;
            txtFine.Location = new Point(283, 133);
            txtFine.Name = "txtFine";
            txtFine.Size = new Size(128, 25);
            txtFine.TabIndex = 6;
            txtFine.Text = "Fine Amount : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(269, 46);
            textBox1.TabIndex = 7;
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1096, 474);
            Controls.Add(textBox1);
            Controls.Add(txtFine);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpReturnDate);
            Controls.Add(dataGridView1);
            Controls.Add(cmbIssueID);
            Controls.Add(btnReturn);
            ForeColor = Color.Black;
            Name = "ReturnBookForm";
            Text = "Return Book";
            Load += ReturnBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private ComboBox cmbIssueID;
        private DataGridView dataGridView1;
        private DateTimePicker dtpReturnDate;
        private Label label1;
        private Label label2;
        private Label txtFine;
        private TextBox textBox1;
    }
}