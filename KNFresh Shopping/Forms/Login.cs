using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace KNFresh_Shopping
{
    public partial class Login : Form
    {

        private string conn;
        private MySqlConnection connect;

        public Login()
        {
            InitializeComponent();
        }

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
            //Select all values from the login database using the username and password entered to see if it is a valid combination
            cmd.CommandText = "Select * from db_login where username=@user and password=@pass";
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
                MessageBox.Show("Empty Fields Detected ! Please fill all the fields","Attention!");
                return;
            }
            //If Login is valid
            bool login = validate_login(user, pass);
            if (login)
            {
                //Show that user has been found and display a welcome message
                MessageBox.Show($"User Found! Welcome Back {user}!","Welcome Back!");
                //Close current form
                this.Hide();
                BarcodeEntry entry = new BarcodeEntry();
                //Open Entry form
                entry.Show();
            }
            else
            {
                //Otherwise display message saying there is a problem
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
                //If the checkbox is unchecked, set the password character to * sign
                passwordtxt.PasswordChar = '*';
            }
        }

        //When the quit button is clicked
        private void quit_Click(object sender, EventArgs e)
        {
            //Exit Application
            Application.Exit();
        }

        //When the link to login as admin is clicked
        private void adminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close this form
            this.Hide();
            Forms.AdminLogin admin = new Forms.AdminLogin();
            //Open the admin login form
            admin.Show();
        }

        //When the link to register a user is clicked
        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close this form
            this.Hide();
            Forms.Register register = new Forms.Register();
            //Open the registration form
            register.Show();
        }
    }

}
