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
    public partial class CardCheckout : Form
    {
        public CardCheckout()
        {
            InitializeComponent();

        }
        //When checkout form is loaded
        private void CardCheckout_Load(object sender, EventArgs e)
        {
            //Load pay button with text saying "pay" and using the value from the previous form called saveText
            payBtn.Text = "Pay " + BarcodeShopping.saveText;
        }
        //When back button is clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            Checkout pay = new Checkout();
            //Show pay form
            pay.Show();
        }
        //When pay button is clicked
        private void payBtn_Click(object sender, EventArgs e)
        {
            //If textboxes equal nothing
            if (nameonCard.Text == "" || cardNumber.Text == "" || postalCode.Text == "" || expiry.Text == "" || securityCode.Text == "")
            {
                //Show textbox saying one or more fields is empty
                MessageBox.Show("One or more fields are empty, Please enter your details to complete the transaction!", "Payment Unsuccessful!");
            }
            else
            {
                //Otherwise show that the purchase was successful
                MessageBox.Show("Purchase Successful", "Success!");
                //Close this form
                this.Hide();
                BarcodeExiting exit = new BarcodeExiting();
                //Show exit form
                exit.Show();
            }

        }
    }
}
