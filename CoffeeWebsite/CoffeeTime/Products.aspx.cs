using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace CoffeeWebsite.CoffeeTime
{
    public partial class Products : Page
    {
        private SqlConnection _connection =
            new SqlConnection(
                @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\A Nazir\Documents\CoffeeTime.mdf; Integrated Security = True; Connect Timeout = 30");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


    }
}