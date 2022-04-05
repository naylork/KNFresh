using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNFresh_Shopping.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            // If the password entered in password textbox has a minimum of 8 characters with one Capital letter, a lower case letter and one number or special character.
            // And Username length is more than or equal to 6 characters
            if (new Regex(@"(?-i)(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))((?=(.*\d){1,})|(?=(.*\W){1,}))^.*$").IsMatch(txtpassword.Text) && txtusername.Text.Length >= 6)
            {
                //If the confirm password and password textbox equal the same value
                if (txtconfirmpassword.Text == txtpassword.Text)
                {
                    //Do
                    try
                    {
                        //Connection String to connect application to database, using server address, database name and password
                        string conn = "Server=knfreshdb.cpuy0oguurx6.us-east-1.rds.amazonaws.com;Database=KNFresh;Uid=admin;Pwd=KNFresh22;";
                        //Insert values in the username and password textboxes to the database db_login
                        string Query = "INSERT INTO db_login (username, password) VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "');";
                        MySqlConnection con = new MySqlConnection(conn);
                        MySqlCommand cmd = new MySqlCommand(Query, con);
                        MySqlDataReader read;
                        //Open Connection
                        con.Open();
                        read = cmd.ExecuteReader();
                        //Show that the user has been registered
                        MessageBox.Show("User Has Been Successfully Registered","Registration Successful");
                        //Clear textboxes
                        txtusername.Clear();
                        txtpassword.Clear();
                        while (read.Read())
                        {
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        //Throw Exception message
                        MessageBox.Show(ex.Message);
                    }
                    //Close form
                    this.Hide();
                    Login login = new Login();
                    //Show Login Form
                    login.Show();
                }
                else
                {
                    //Tell user that the passwords entered dont match
                    MessageBox.Show("Your passwords do not match","Attention!"); 
                }
            }
            else
            {
                //Tell user that the username already exists or passowrd complexity requirements aren't good enough
                MessageBox.Show("Username already Exists, or Password Does not meet Complexity Requirements","Login Error");
            }
        }


        //Once the login link is clicked
        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close this form
            this.Hide();
            Login login = new Login();
            //Show login form
            login.Show();
        }

        //If the checkbox to show password is clicked
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Once the checkbox has been checked
            if (showPassword.Checked)
            {
                //Define pass vairable as password text
                string pass = txtpassword.Text;
                //Sets the password character to normal text
                txtpassword.PasswordChar = '\0';
                //Define pass vairable as confirm password text
                string confpass = txtconfirmpassword.Text;
                //Sets the password character to normal text
                txtconfirmpassword.PasswordChar = '\0';
            }
            else
            {
                //If the checkbox is unchecked, set the password character to * sign
                txtpassword.PasswordChar = '*';
                //If the checkbox is unchecked, set the confirm password character to * sign
                txtconfirmpassword.PasswordChar = '*';
            }
        }

        //When the back button is clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            Login login = new Login();
            //Show login form
            login.Show();
        }
    }
}
