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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        public void LoadStudents()
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Student";

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
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "INSERT INTO Student (Name, Department) VALUES (@name, @department)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Added Successfully!");

                LoadStudents();

                txtName.Clear();
                txtDepartment.Clear();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDepartment.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
        
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                // Delete related issue records first
                string issueQuery = "DELETE FROM IssueRecord WHERE StudentID=@id";

                MySqlCommand issueCmd = new MySqlCommand(issueQuery, conn);

                issueCmd.Parameters.AddWithValue("@id", txtStudentID.Text);

                issueCmd.ExecuteNonQuery();

                // Delete student
                string studentQuery = "DELETE FROM Student WHERE StudentID=@id";

                MySqlCommand studentCmd = new MySqlCommand(studentQuery, conn);

                studentCmd.Parameters.AddWithValue("@id", txtStudentID.Text);

                int rows = studentCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Student Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }

                LoadStudents();

                txtStudentID.Text = "";
                txtName.Text = "";
                txtDepartment.Text = "";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "UPDATE Student SET Name=@name, Department=@department WHERE StudentID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Updated Successfully!");

                LoadStudents();

                txtStudentID.Clear();
                txtName.Clear();
                txtDepartment.Clear();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtName.Text = "";
            txtDepartment.Text = "";

            dataGridView1.ClearSelection();

            txtName.Focus();
        }
    }
}
