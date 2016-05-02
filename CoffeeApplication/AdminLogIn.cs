using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoffeeApplication
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Log In Validations

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
            }

            //SQL Connection - Link to the login sql database

            var conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\A Nazir\Documents\CoffeeTime.mdf; Integrated Security = True; Connect Timeout = 30");
            conn.Open();
            var sqlData = new SqlDataAdapter("SELECT COUNT(*) FROM LogIn WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'", conn);
            var dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //Checks to see if log in credentials match with the database

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Hide();
                new AdminPanel().Show(); //Log in to Admin Panel
            }

            else

                MessageBox.Show("Incorrect Username or Password");

            //SQL Connection Close

            conn.Close();
        }
    }
} 