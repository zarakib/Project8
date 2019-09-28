using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrderP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //connection 
            string connectionString = @"Server=DESKTOP-IN2FMRP; Database=CoffeeShop2; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //command
            string commanadString = @"INSERT INTO Customer (Name, Addres ) Values ('" + nameTextBox.Text + "', '" +addressTextBox.Text+ "')";
            SqlCommand sqlCommand = new SqlCommand(commanadString, sqlConnection);


            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //connection 
            string connectionString = @"Server=DESKTOP-IN2FMRP; Database=CoffeeShop2; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //command
            string commanadString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commanadString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            showDataGridView.DataSource = dataTable;
                sqlConnection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //connection 
            string connectionString = @"Server=DESKTOP-IN2FMRP; Database=CoffeeShop2; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //command
            string commanadString = @"SELECT * FROM Customer WHERE ID='" + idTextBox.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(commanadString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //connection 
            string connectionString = @"Server=DESKTOP-IN2FMRP; Database=CoffeeShop2; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //command
            string commanadString = @"DELETE FROM Customer WHERE ID = " + idTextBox.Text + "";
            SqlCommand sqlCommand = new SqlCommand(commanadString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //connection 
            string connectionString = @"Server=DESKTOP-IN2FMRP; Database=CoffeeShop2; Integrated Security= True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);



            //command
            string commanadString = @"UPDATE Customer SET Addres =" + addressTextBox.Text + " WHERE ID = " + idTextBox.Text + "";
            SqlCommand sqlCommand = new SqlCommand(commanadString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
