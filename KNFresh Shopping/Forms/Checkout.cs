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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        //Variable for checkbox last checked
        CheckBox lastChecked;
        //When checkout form is loaded
        private void Checkout_Load(object sender, EventArgs e)
        {
            //Set total price textbox as value from barcode shopping form
            totalPrice.Text = BarcodeShopping.saveText;
        }
        //When pay button is clicked
        private void payBtn_Click(object sender, EventArgs e)
        {
            //If card checkbox is checked
            if (cardCheck.Checked == true)
            {
                //Close form
                this.Hide();
                CardCheckout card = new CardCheckout();
                //Show card checkout form
                card.Show();
            }
        }
        //When card checkbox is checked
        private void cardCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Retrieve checkbox variable
            CheckBox activeCheckBox = sender as CheckBox;
            //If this checkbox is checked and there is already an active checkbox, disable the previous one and make this one active
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            //Set as checked
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }
        //When paypal checkbox is checked
        private void paypalCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }
        //When apple pay checkbox is checked
        private void appleCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }
        //When googlepay checkbox is checked
        private void googleCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }
    }
}
