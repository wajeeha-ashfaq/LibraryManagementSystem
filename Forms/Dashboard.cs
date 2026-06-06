using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Database; 

namespace LibraryManagementSystem.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm();
            bf.Show();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBookForm ib = new IssueBookForm();
            ib.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm rb = new ReturnBookForm();
            rb.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBookForm sb = new SearchBookForm();
            sb.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();

            lf.Show();

            this.Hide();
        }
    }
}
