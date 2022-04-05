using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNFresh_Shopping
{
    public partial class Shopping_Tips : Form
    {
        public Shopping_Tips()
        {
            InitializeComponent();
        }

        //Once continue button has been clicked
        private void cntButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            BarcodeShopping shop = new BarcodeShopping();
            //Show shopping form
            shop.Show();
        }

        private void Shopping_Tips_Load(object sender, EventArgs e)
        {

        }

        //Once back button has been clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
            BarcodeEntry entry = new BarcodeEntry();
            //Show entry form
            entry.Show();
        }
    }
}
