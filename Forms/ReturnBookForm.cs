using MySql.Data.MySqlClient;
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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }
        public void LoadReturnedBooks()
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = @"SELECT
                         IssueRecord.IssueID,
                         Book.Title,
                         Student.Name,
                         IssueRecord.IssueDate,
                         IssueRecord.ReturnDate,
                         IssueRecord.FineAmount

                         FROM IssueRecord

                         INNER JOIN Book
                         ON IssueRecord.BookID = Book.BookID

                         INNER JOIN Student
                         ON IssueRecord.StudentID = Student.StudentID";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadIssueIDs()
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT IssueID FROM IssueRecord WHERE ReturnDate IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbIssueID.Items.Add(reader["IssueID"]?.ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            LoadIssueIDs();
            LoadReturnedBooks();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
        
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                int fine = 0;

                string query = @"UPDATE IssueRecord
                         SET ReturnDate=@returnDate,
                         FineAmount=@fine
                         WHERE IssueID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value);
                cmd.Parameters.AddWithValue("@fine", fine);
                cmd.Parameters.AddWithValue("@id", cmbIssueID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Returned Successfully!");
                LoadReturnedBooks();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
