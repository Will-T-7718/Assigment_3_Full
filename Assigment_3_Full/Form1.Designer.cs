namespace Assigment_3_Full
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.btn_Checkout);
            this.panel1.Controls.Add(this.btn_Inventory);
            this.panel1.Controls.Add(this.btn_Products);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 86);
            this.panel1.TabIndex = 0;
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Location = new System.Drawing.Point(372, 34);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Inventory.TabIndex = 2;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.Location = new System.Drawing.Point(208, 34);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(75, 23);
            this.btn_Products.TabIndex = 1;
            this.btn_Products.Text = "Products";
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(54, 34);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlContent.Location = new System.Drawing.Point(0, 82);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(801, 370);
            this.pnlContent.TabIndex = 1;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Location = new System.Drawing.Point(515, 33);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_Checkout.TabIndex = 3;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Panel pnlContent;
    }
}

