using MySql.Data.MySqlClient;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Administrator WHERE Username=@username AND Password=@password";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful!");

                    Dashboard dash = new Dashboard();
                    dash.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
