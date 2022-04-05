using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace KNFresh_Shopping
{
    public partial class BarcodeEntry : Form
    {
        //Define variables
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        public BarcodeEntry( )
        {
            InitializeComponent( );

        }

        //When the form loads
        private void BarcodeEntry_Load( object sender, EventArgs e )
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
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //Start the video device
            videoCaptureDevice.Start();
            //Start the timer
            timer1.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //Set picture box to receive image
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        //Everytime the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            //If there is an image in the picturebox
            if (pictureBox1.Image != null)
            {
                //Define barcode reader
                BarcodeReader barcodeReader = new BarcodeReader();
                //Set result to show end product of barcode reader, decode the text seen in the picture box
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                //If there is a result
                if (result != null)
                {
                    //Send value to textbox
                    textBox1.Text = result.ToString();
                    //Stop the timer
                    timer1.Stop();
                }

            }
        }

        //If textbox text changes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //If the text in the textbox equals "Hello, and Welcome to KNFresh Coventry!!"
            if (textBox1.Text == "Hello, and Welcome to KNFresh Coventry!!")
            {
                //Stop video device
                videoCaptureDevice.Stop();
                //Show message
                MessageBox.Show("Hello, and Welcome to KNFresh Coventry!!","Welcome!!");
                //Close current form
                this.Hide();
                Shopping_Tips tips = new Shopping_Tips();
                //Show tips form
                tips.Show();
            }
            else
            {

            }

        }

        //When back button is clicked
        private void backButton_Click(object sender, EventArgs e)
        {
            //Stop the video device
            videoCaptureDevice.Stop();
            //Close this form
            this.Hide();
            Login login = new Login();
            //Open Login Form
            login.Show();
        }
    }
}
