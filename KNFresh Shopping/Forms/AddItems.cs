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

namespace KNFresh_Shopping.Forms
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private string conn;
        private MySqlConnection connect;

        //Define the database connection
        private void DB_connection()
        {
            try
            {
                //Connection String to connect application to database, using server address, database name and password
                conn = "Server=knfreshdb.cpuy0oguurx6.us-east-1.rds.amazonaws.com;Database=KNFresh;Uid=admin;Pwd=KNFresh22;";
                connect = new MySqlConnection(conn);
            }
            catch (Exception ex)
            {
                //Throw exception if connection doesn't work
                MessageBox.Show(ex.ToString());
            }
        }

        //When the form loads
        private void AddItems_Load(object sender, EventArgs e)
        {
            //Display message welcoming the user who's logged in
            label5.Text = "Hello " + AdminLogin.username + ", Welcome back to the Admin Portal!";
            //Connect user using connection string
            DB_connection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Select all values from the db_price table
            string sql = "Select * from db_price";
            //Create a new dataset to copy the sql values to it
            DataSet ds = new DataSet();

            try
            {
                //Open connection
                connect.Open();
                //Use the sql query and connection string
                adapter = new MySqlDataAdapter(sql, conn);
                //Fill the dataset with the values from database
                adapter.Fill(ds);
                //Close connection
                connect.Close();
                //Set the data source of the datagrid
                itemsDb.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Throw exception if error
                MessageBox.Show(ex.ToString());
            }
        }

        //Once the retrieve button is clicked
        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            //Connect to database using connection string
            DB_connection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Select all values from the db_price table
            string sql = "Select * from db_price";
            //Create a new dataset to copy the sql values to it
            DataSet ds = new DataSet();

            try
            {
                //Open Connection
                connect.Open();
                //Use the sql query and connection string
                adapter = new MySqlDataAdapter(sql, conn);
                //Fill the dataset with the values from database
                adapter.Fill(ds);
                //Clear textboxes
                barcodeText.Clear();
                descriptionText.Clear();
                priceText.Clear();
                connect.Close();
                //Set the data source of the datagrid
                itemsDb.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Throw exception if error
                MessageBox.Show(ex.ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (barcodeText.Text.Length == 9 && descriptionText.Text.Length >= 6 && priceText.Text.Length >= 1)
            {
                try
                {
                    //Connect to database using connection string
                    DB_connection();
                    //Insert values from barcode textbox, description textbox and price textbox into the item database
                    string Query = "INSERT INTO db_price (barcode, description, price) VALUES ('" + barcodeText.Text + "','" + descriptionText.Text + "','" + priceText.Text + "');";
                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    MySqlDataReader read;
                    //Open Connection
                    con.Open();
                    read = cmd.ExecuteReader();
                    //Show message telling user the item has been added
                    MessageBox.Show("Item Added to Database", "Addition Successful!");
                    //Clear textboxes
                    barcodeText.Clear();
                    descriptionText.Clear();
                    priceText.Clear();
                    while (read.Read())
                    {
                    }
                    //Close connection
                    con.Close();
                }
                catch (Exception ex)
                {
                    //Throw exception if error
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Tell user that the values they've entered aren't valid
                MessageBox.Show("Sorry, the values you've entered aren't valid", "Error");
            }

        }

        //Select row in database
        private void itemsDb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Select row from datagrid
                DataGridViewRow row = this.itemsDb.Rows[e.RowIndex];
                //Move values from column "barcode" in database to the barcode textbox
                barcodeText.Text = row.Cells["barcode"].Value.ToString();
                //Move values from column "description" in database to the description textbox
                descriptionText.Text = row.Cells["description"].Value.ToString();
                //Move values from column "price" in database to the price textbox
                priceText.Text = row.Cells["price"].Value.ToString();
            }
        }

        //When update button is selected
        private void updateSelected_Click(object sender, EventArgs e)
        {
            try
            { 
                //Connect to database using connection string
                DB_connection();
                //Update the items database and set the barcode to barcode text, description to description text, price to price text
                string Query = "UPDATE db_price SET barcode='" + barcodeText.Text + "', description='" + descriptionText.Text + "', price='" + priceText.Text + "' WHERE barcode= '"+ barcodeText.Text +"';";
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader read;
                //Open Connection
                con.Open();
                read = cmd.ExecuteReader();
                //Show that the item has been updated to database successfully
                MessageBox.Show("Item Updated Successfully", "Change Successful!");
                //Clear textboxes
                barcodeText.Clear();
                descriptionText.Clear();
                priceText.Clear();
                while (read.Read())
                {
                }
                //Close connection
                con.Close();
            }
            catch (Exception ex)
            {
                //Throw exception if error
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect to database using connection string
                DB_connection();
                //Delete record from the item database where the barcode in db equals the barcode in the textbox
                string Query = "DELETE from db_price WHERE barcode= '" + barcodeText.Text + "';";
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader read;
                //Open Connection
                con.Open();
                read = cmd.ExecuteReader();
                //Show message telling user the record has been deleted
                MessageBox.Show("Item Deleted", "Deletion Successful!");
                //Clear textboxes
                barcodeText.Clear();
                descriptionText.Clear();
                priceText.Clear();
                while (read.Read())
                {
                }
                //Close connection
                con.Close();
            }
            catch (Exception ex)
            {
                //Throw exception on error
                MessageBox.Show(ex.Message);
            }
        }

        //Once back button is clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            AdminLogin adlog = new AdminLogin();
            //Show admin login form
            adlog.Show();
        }

        private void barcodeText_Click(object sender, EventArgs e)
        {
            //Clear textbox
            barcodeText.Clear();
        }

        private void descriptionText_Click(object sender, EventArgs e)
        {
            //Clear textbox
            descriptionText.Clear();
        }
    }
}
