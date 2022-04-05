using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using ZXing;

namespace KNFresh_Shopping
{
    public partial class BarcodeShopping : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        //Public variable to save text across forms
        public static string saveText;

        public BarcodeShopping( )
        {
            InitializeComponent( );
        }

        //Set connection string
        MySqlConnection conn = new MySqlConnection("Server=knfreshdb.cpuy0oguurx6.us-east-1.rds.amazonaws.com;Database=KNFresh;Uid=admin;Pwd=KNFresh22;");


        // Main form is loaded
        private void BarcodeShopping_Load( object sender, EventArgs e )
        {
            //Find video input device
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //For every input device
            foreach (FilterInfo device in filterInfoCollection)
                //Add input device to combo box
                devicesCombo.Items.Add(device.Name);
            //Select the first device in combo box
            devicesCombo.SelectedIndex = 0;
            //Use the video device selected from the combo box
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[devicesCombo.SelectedIndex].MonikerString);
            //Set video device to show in frame of picture box
            videoCaptureDevice.NewFrame += videoDevices_NewFrame;
            //Start the video device
            videoCaptureDevice.Start();

        }


        private void videoDevices_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //Clone camera to picturebox
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            //Read the value on the camera
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    //Move text from camera to textbox
                    textBox1.Text = result.ToString();
                }));
            }
            //Set picture box to receive image
            pictureBox1.Image = bitmap;
        }

        //When form closes
        private void BarcodeShopping_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If camera running
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    //Stop camera
                    videoCaptureDevice.Stop();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Open connection
            conn.Open();
            //Select the description and price from item database where the barcode equals the value from the camera
            MySqlCommand command = new MySqlCommand("select description, price from db_price where barcode = '" + textBox1.Text + "'", conn);
            MySqlDataReader srd = command.ExecuteReader();
            while (srd.Read())
            {
                //Move first value to the product textbox
                tb_product.Text = srd.GetValue(0).ToString();
                if (string.IsNullOrEmpty(tb_product.Text))
                    return;
                //Move value from textbox to shopping basket
                shoppingBasket.Items.Add(tb_product.Text);
                //Move second value to the price textbox and put £ in front
                tb_price.Text = "£" + srd.GetValue(1).ToString();

            }
            //Close connection
            conn.Close();
        }

        //When remove button is clicked
        private void rmvButton_Click(object sender, EventArgs e)
        {
            //If the shopping basket has more than one value
            if (shoppingBasket.Items.Count > 0)
                //remove selected value
                shoppingBasket.Items.RemoveAt(shoppingBasket.SelectedIndex);
            //Clear textboxes
            tb_product.Clear();
            tb_price.Clear();
            textBox1.Clear();
        }

        //When the checkout button is clicked
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            //For every item in shopping basket
            for (int i = 0; i < shoppingBasket.Items.Count; i++)
            {
                //Select each item
                shoppingBasket.SetSelected(i, true);
                //Open connection
                conn.Open();
                //Select all values from item database that are found in the shopping basket and add the total price of items together
                MySqlCommand command = new MySqlCommand("SELECT SUM(price) FROM db_price AS TotalPrice WHERE description = '" + shoppingBasket.Text + "'", conn);
                MySqlDataReader srd = command.ExecuteReader();
                while (srd.Read())
                {
                    //Move total price of all values to textbox
                    totalPrice.Text = srd.GetValue(0).ToString();
                    if (string.IsNullOrEmpty(totalPrice.Text))
                        return;
                    //Move all items from listbox to total price textbox
                    listBox2.Items.Add(totalPrice.Text);
                }
                //Close connection
                conn.Close();
                //Start value at 0
                decimal sum = 0;
                //For each item in the total price listbox
                for (int t = 0; t < listBox2.Items.Count; t++)
                {
                    //Add them all together and convert decimal values to a sum
                    sum += Convert.ToDecimal(listBox2.Items[t]);
                }
                //Turn sum into string and add £ to the front of value
                totalPrice.Text = "£" + Convert.ToString(sum);

            }

            //Show message with totalprice included
            DialogResult dialogResult = MessageBox.Show("Your total comes to "+totalPrice.Text+". Are you ready to checkout?", "Checkout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Stop video device
                videoCaptureDevice.Stop();
                //Close form
                this.Hide();
                //Set save text variable to the value of total price textbox
                saveText = totalPrice.Text;
                Forms.Checkout checkout = new Forms.Checkout();
                //Open checkout form
                checkout.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        //When back button is clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Stop video device
            videoCaptureDevice.Stop();
            //Hide form
            this.Hide();
            Shopping_Tips tips = new Shopping_Tips();
            //Show previous form
            tips.Show();
        }
    }
}
