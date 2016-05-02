using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CoffeeApplication.Properties;

namespace CoffeeApplication
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeTimeDataSet.Coffee' table. You can move, or remove it, as needed.
            coffeeTableAdapter.Fill(coffeeTimeDataSet.Coffee);
            
        }

        private void dgCoffee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load Coffee Data in TextBoxes

            if (dgCoffee.CurrentRow == null) return;
            txtCoffeeID.Text = dgCoffee.CurrentRow.Cells[0].Value.ToString();
            txtCoffeeName.Text = dgCoffee.CurrentRow.Cells[1].Value.ToString();
            txtCoffeePrice.Text = dgCoffee.CurrentRow.Cells[2].Value.ToString();
            txtCoffeeOrigin.Text = dgCoffee.CurrentRow.Cells[3].Value.ToString();
            txtCoffeeStrength.Text = dgCoffee.CurrentRow.Cells[4].Value.ToString();
            txtCoffeeGrind.Text = dgCoffee.CurrentRow.Cells[5].Value.ToString();
            txtCoffeeQty.Text = dgCoffee.CurrentRow.Cells[6].Value.ToString();
            txtDescription.Text = dgCoffee.CurrentRow.Cells[7].Value.ToString();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Coffee to Database

            var connection =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A Nazir\Documents\CoffeeTime.mdf;Integrated Security=True;Connect Timeout=30");
            var addRecord =
                new SqlCommand(
                    "INSERT INTO Coffee VALUES('" + txtCoffeeID.Text + "', '" + txtCoffeeName.Text + "', '" +
                    txtCoffeePrice.Text + "', '" + txtCoffeeOrigin.Text + "' , '" + txtCoffeeStrength.Text + "' , '" +
                    txtCoffeeGrind.Text + "' , '" + txtCoffeeQty.Text + "' , '" + txtDescription.Text + "')", connection);
            connection.Open();
            addRecord.ExecuteNonQuery();
            connection.Close();
            coffeeTableAdapter.Fill(coffeeTimeDataSet.Coffee);
            MessageBox.Show("Are you sure you want to Add Coffee ID" + txtCoffeeID.Text);
            MessageBox.Show("Coffee Successfully Added");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Update Coffee Record from Database
            coffeeTableAdapter.Update(coffeeTimeDataSet);
            MessageBox.Show("Coffee Record Successfully Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Coffee Record from Database
            var connection =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\A Nazir\Documents\CoffeeTime.mdf;Integrated Security=True;Connect Timeout=30");
            var deleteRecord = new SqlCommand("DELETE FROM Coffee WHERE [CoffeeID] = " + txtDelete.Text, connection);
            connection.Open();
            deleteRecord.ExecuteNonQuery();
            connection.Close();
            coffeeTableAdapter.Fill(coffeeTimeDataSet.Coffee);
            MessageBox.Show("Are you sure you want to Delete Coffee ID" + txtCoffeeID.Text);
            MessageBox.Show("Coffee Successfully Deleted");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //Filter Search Query
            var dataView = new DataView(coffeeTimeDataSet.Coffee);
            dgCoffee.DataSource = dataView;

            dataView.RowFilter = $"[CoffeeGrind] LIKE '{txtFilter.Text}%'";
            dgCoffee.DataSource = dataView;
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update DataGrid through Combo Box 
           
            coffeeTableAdapter.Update(coffeeTimeDataSet);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide(); //hiding Admin Panel
            var login = new AdminLogin();
            login.Show(); //showing Admin Screen
        }

    }
}