using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace CoffeeWebsite.CoffeeTime
{
    public partial class LogIn : Page
    {
         private SqlConnection _connection =
            new SqlConnection(
                @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\A Nazir\Documents\CoffeeTime.mdf; Integrated Security = True; Connect Timeout = 30");

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //Create SQL Connection to the Database

            var connection =
                new SqlConnection(
                    @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\A Nazir\Documents\CoffeeTime.mdf; Integrated Security = True; Connect Timeout = 30");

            const string strSelect = "SELECT COUNT(*) FROM LogIn WHERE Username = @Username AND Password = @Password";

            var cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = strSelect
            };

            var Username = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = txtUsername.Text.Trim()
                
            };

            cmd.Parameters.Add(Username);

            var Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            {
                Password.Value = txtPassword.Text.Trim();
            }
                     
            cmd.Parameters.Add(Password);

            connection.Open();

            var result = (int) cmd.ExecuteScalar();

            connection.Close();

            if (result >= 1)

            {
                Response.Redirect("Admin.aspx");
            }

            else

                lblMsg.Text = "Incorrect Username or Password";
        }
    }
}