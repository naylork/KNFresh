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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private string conn;
        private MySqlConnection connect;

        //Connection class for database
        private void db_connection()
        {
            try
            {
                //Connection String to connect application to database, using server address, database name and password
                conn = "Server=knfreshdb.cpuy0oguurx6.us-east-1.rds.amazonaws.com;Database=KNFresh;Uid=admin;Pwd=KNFresh22;";
                //Connect user using connection string
                connect = new MySqlConnection(conn);
                //Open connection
                connect.Open();
            }
            catch (MySqlException ex)
            {
                //If connection fails show error message
                MessageBox.Show(ex.ToString());
            }
        }

        //Checks to see if login is valid
        private bool validate_login(string user, string pass)
        {
            //Call connection class to connect user
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            //Select all values from the admin login database using the username and password entered to see if it is a valid combination
            cmd.CommandText = "Select * from db_Adminlogin where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            //Read the values retrieved from the database
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                //Close connection and say that the login is valid
                connect.Close();
                return true;
            }
            else
            {
                //Close connection and say that the login is invalid
                connect.Close();
                return false;
            }
        }

        public static string username;

        //When Login Button is clicked
        private void loginbtn_Click(object sender, EventArgs e)
        {
            //Variable user equals the username textbox, and variable pass equals the password textbox
            string user = usernametxt.Text;
            string pass = passwordtxt.Text;
            //If the username and password fields are left empty
            if (user == "" || pass == "")
            {
                //Show message saying there is a problem
                MessageBox.Show("Empty Fields Detected ! Please fill all the fields", "Attention!");
                return;
            }
            //If Login is valid
            bool login = validate_login(user, pass);
            if (login)
            {
                //Define username as what is entered in username text
                username = usernametxt.Text;
                //Show that user has been found and display a welcome message
                MessageBox.Show($"User Found! Welcome Back {user}!", "Welcome Back!");
                //Close current form
                this.Hide();
                AddItems Portal = new AddItems();
                //Open portal form
                Portal.Show();

            }
            else
            {
                //Show message telling user there is a problem
                MessageBox.Show("Incorrect Login Credentials", "Login Error!");
            }
        }

        //If the checkbox to show password is clicked
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Once the checkbox has been checked
            if (showPassword.Checked)
            {
                //Define pass vairable as password text
                string pass = passwordtxt.Text;
                //Sets the password character to normal text
                passwordtxt.PasswordChar = '\0';
            }
            else
            {
                //IF the checkbox is unchecked, set the password character to * sign
                passwordtxt.PasswordChar = '*';
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            Login login = new Login();
            //Open the login form
            login.Show();
        }
    }
}
