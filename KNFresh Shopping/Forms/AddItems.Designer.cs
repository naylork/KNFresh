
namespace KNFresh_Shopping.Forms
{
    partial class AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.retrieveBtn = new System.Windows.Forms.Button();
            this.itemsDb = new System.Windows.Forms.DataGridView();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateSelected = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(-2, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 10);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 108);
            this.panel1.TabIndex = 27;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("backButton.InitialImage")));
            this.backButton.Location = new System.Drawing.Point(432, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 21;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 88);
            this.label5.TabIndex = 18;
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.retrieveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.retrieveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrieveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveBtn.Location = new System.Drawing.Point(18, 406);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(116, 32);
            this.retrieveBtn.TabIndex = 31;
            this.retrieveBtn.Text = "Refresh";
            this.retrieveBtn.UseVisualStyleBackColor = false;
            this.retrieveBtn.Click += new System.EventHandler(this.retrieveBtn_Click);
            // 
            // itemsDb
            // 
            this.itemsDb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDb.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemsDb.Location = new System.Drawing.Point(12, 444);
            this.itemsDb.Name = "itemsDb";
            this.itemsDb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDb.Size = new System.Drawing.Size(468, 150);
            this.itemsDb.TabIndex = 32;
            this.itemsDb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDb_CellContentClick);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(35, 292);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(216, 20);
            this.descriptionText.TabIndex = 33;
            this.descriptionText.Text = "Must be more than 5 Characters";
            this.descriptionText.Click += new System.EventHandler(this.descriptionText_Click);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(35, 357);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(216, 20);
            this.priceText.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Barcode No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Price";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(364, 349);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 50);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(364, 211);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 50);
            this.addButton.TabIndex = 41;
            this.addButton.Text = "Add Selected";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateSelected
            // 
            this.updateSelected.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateSelected.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSelected.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSelected.Location = new System.Drawing.Point(364, 281);
            this.updateSelected.Name = "updateSelected";
            this.updateSelected.Size = new System.Drawing.Size(116, 50);
            this.updateSelected.TabIndex = 42;
            this.updateSelected.Text = "Update Selected";
            this.updateSelected.UseVisualStyleBackColor = false;
            this.updateSelected.Click += new System.EventHandler(this.updateSelected_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 95);
            this.label4.TabIndex = 43;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barcodeText
            // 
            this.barcodeText.Location = new System.Drawing.Point(35, 228);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(216, 20);
            this.barcodeText.TabIndex = 30;
            this.barcodeText.Text = "Must be 9 Characters";
            this.barcodeText.Click += new System.EventHandler(this.barcodeText_Click);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateSelected);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.itemsDb);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button retrieveBtn;
        private System.Windows.Forms.DataGridView itemsDb;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateSelected;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox barcodeText;
    }
}