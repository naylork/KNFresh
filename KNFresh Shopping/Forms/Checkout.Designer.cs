
namespace KNFresh_Shopping.Forms
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cardCheck = new System.Windows.Forms.CheckBox();
            this.paypalCheck = new System.Windows.Forms.CheckBox();
            this.appleCheck = new System.Windows.Forms.CheckBox();
            this.googleCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblproductsBindingSource
            // 
            this.tblproductsBindingSource.DataMember = "tbl_products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total Price:";
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPrice.Enabled = false;
            this.totalPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(115, 180);
            this.totalPrice.Multiline = true;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(180, 35);
            this.totalPrice.TabIndex = 27;
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 96);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Checkout";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-5, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 10);
            this.panel2.TabIndex = 30;
            // 
            // cardCheck
            // 
            this.cardCheck.AutoSize = true;
            this.cardCheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardCheck.Location = new System.Drawing.Point(159, 242);
            this.cardCheck.Name = "cardCheck";
            this.cardCheck.Size = new System.Drawing.Size(57, 20);
            this.cardCheck.TabIndex = 31;
            this.cardCheck.Text = "Card";
            this.cardCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardCheck.UseVisualStyleBackColor = true;
            this.cardCheck.CheckedChanged += new System.EventHandler(this.cardCheck_CheckedChanged);
            // 
            // paypalCheck
            // 
            this.paypalCheck.AutoSize = true;
            this.paypalCheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypalCheck.Location = new System.Drawing.Point(159, 265);
            this.paypalCheck.Name = "paypalCheck";
            this.paypalCheck.Size = new System.Drawing.Size(72, 20);
            this.paypalCheck.TabIndex = 32;
            this.paypalCheck.Text = "PayPal";
            this.paypalCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paypalCheck.UseVisualStyleBackColor = true;
            this.paypalCheck.CheckedChanged += new System.EventHandler(this.paypalCheck_CheckedChanged);
            // 
            // appleCheck
            // 
            this.appleCheck.AutoSize = true;
            this.appleCheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appleCheck.Location = new System.Drawing.Point(159, 288);
            this.appleCheck.Name = "appleCheck";
            this.appleCheck.Size = new System.Drawing.Size(92, 20);
            this.appleCheck.TabIndex = 33;
            this.appleCheck.Text = "Apple Pay";
            this.appleCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appleCheck.UseVisualStyleBackColor = true;
            this.appleCheck.CheckedChanged += new System.EventHandler(this.appleCheck_CheckedChanged);
            // 
            // googleCheck
            // 
            this.googleCheck.AutoSize = true;
            this.googleCheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleCheck.Location = new System.Drawing.Point(159, 311);
            this.googleCheck.Name = "googleCheck";
            this.googleCheck.Size = new System.Drawing.Size(101, 20);
            this.googleCheck.TabIndex = 34;
            this.googleCheck.Text = "Google Pay";
            this.googleCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.googleCheck.UseVisualStyleBackColor = true;
            this.googleCheck.CheckedChanged += new System.EventHandler(this.googleCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 447);
            this.Controls.Add(this.googleCheck);
            this.Controls.Add(this.appleCheck);
            this.Controls.Add(this.paypalCheck);
            this.Controls.Add(this.cardCheck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblproductsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblproductsBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cardCheck;
        private System.Windows.Forms.CheckBox paypalCheck;
        private System.Windows.Forms.CheckBox appleCheck;
        private System.Windows.Forms.CheckBox googleCheck;
        private System.Windows.Forms.Button button1;
    }
}