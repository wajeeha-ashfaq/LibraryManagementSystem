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
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.Forms
{
    public partial class BookForm : Form
    {
        public BookForm()
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "INSERT INTO Book (Title, Author, Quantity) VALUES (@title, @author, @quantity)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Added Successfully!");
                LoadBooks();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtQuantity.Clear();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "UPDATE Book SET Title=@title, Author=@author, Quantity=@quantity WHERE BookID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtBookID.Text);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Updated Successfully!");

                conn.Close();

                LoadBooks(); // refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                // Delete related issue records first
                string issueQuery = "DELETE FROM IssueRecord WHERE BookID=@id";

                MySqlCommand issueCmd = new MySqlCommand(issueQuery, conn);

                issueCmd.Parameters.AddWithValue("@id", txtBookID.Text);

                issueCmd.ExecuteNonQuery();

                // Delete book
                string bookQuery = "DELETE FROM Book WHERE BookID=@id";

                MySqlCommand bookCmd = new MySqlCommand(bookQuery, conn);

                bookCmd.Parameters.AddWithValue("@id", txtBookID.Text);

                int rows = bookCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Book Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }

                LoadBooks();

                txtBookID.Text = "";
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtQuantity.Text = "";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtQuantity.Text = "";

            dataGridView1.ClearSelection();

            txtTitle.Focus();
        }
    }

}
