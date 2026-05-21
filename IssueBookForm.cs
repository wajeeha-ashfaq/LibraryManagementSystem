using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }
        public void LoadBooks()
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Book";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBook.Items.Add(reader["Title"]?.ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadStudents()
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Student";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbStudent.Items.Add(reader["Name"]?.ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadStudents();
            LoadIssuedBooks();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            
        
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                // Get BookID
                string bookQuery = "SELECT BookID FROM Book WHERE Title=@title";

                MySqlCommand bookCmd = new MySqlCommand(bookQuery, conn);

                bookCmd.Parameters.AddWithValue("@title", cmbBook.Text);

                int bookID = Convert.ToInt32(bookCmd.ExecuteScalar());

                // Get StudentID
                string studentQuery = "SELECT StudentID FROM Student WHERE Name=@name";

                MySqlCommand studentCmd = new MySqlCommand(studentQuery, conn);

                studentCmd.Parameters.AddWithValue("@name", cmbStudent.Text);

                int studentID = Convert.ToInt32(studentCmd.ExecuteScalar());

                // Insert Issue Record
                string issueQuery = @"INSERT INTO IssueRecord
                              (IssueDate, BookID, StudentID)
                              VALUES
                              (@issueDate, @bookID, @studentID)";

                MySqlCommand issueCmd = new MySqlCommand(issueQuery, conn);

                issueCmd.Parameters.AddWithValue("@issueDate", dtpIssueDate.Value);
                issueCmd.Parameters.AddWithValue("@bookID", bookID);
                issueCmd.Parameters.AddWithValue("@studentID", studentID);

                issueCmd.ExecuteNonQuery();

                MessageBox.Show("Book Issued Successfully!");
                LoadIssuedBooks();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadIssuedBooks()
        {
            
        
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = @"
        SELECT 
            IssueRecord.IssueID,
            Book.Title,
            Student.Name,
            IssueRecord.IssueDate

        FROM IssueRecord

        INNER JOIN Book
        ON IssueRecord.BookID = Book.BookID

        INNER JOIN Student
        ON IssueRecord.StudentID = Student.StudentID

        WHERE IssueRecord.ReturnDate IS NULL";

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
    

    }
}
