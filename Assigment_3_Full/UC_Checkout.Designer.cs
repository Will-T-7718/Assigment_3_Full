namespace Assigment_3_Full
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Final_Price_Label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Final_Price_Checkout = new System.Windows.Forms.TextBox();
            this.Cancel_CheckOut = new System.Windows.Forms.Button();
            this.Confirm_CheckOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_CheckOut_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CheckOut_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Final_Price_Label);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Final_Price_Checkout);
            this.groupBox1.Controls.Add(this.Cancel_CheckOut);
            this.groupBox1.Controls.Add(this.Confirm_CheckOut);
            this.groupBox1.Location = new System.Drawing.Point(117, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(788, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Final_Price_Label
            // 
            this.Final_Price_Label.AutoSize = true;
            this.Final_Price_Label.Location = new System.Drawing.Point(53, 76);
            this.Final_Price_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Final_Price_Label.Name = "Final_Price_Label";
            this.Final_Price_Label.Size = new System.Drawing.Size(70, 16);
            this.Final_Price_Label.TabIndex = 4;
            this.Final_Price_Label.Text = "Final Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Final_Price_Checkout
            // 
            this.Final_Price_Checkout.Location = new System.Drawing.Point(131, 73);
            this.Final_Price_Checkout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Final_Price_Checkout.Name = "Final_Price_Checkout";
            this.Final_Price_Checkout.Size = new System.Drawing.Size(132, 22);
            this.Final_Price_Checkout.TabIndex = 2;
            // 
            // Cancel_CheckOut
            // 
            this.Cancel_CheckOut.Location = new System.Drawing.Point(392, 229);
            this.Cancel_CheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_CheckOut.Name = "Cancel_CheckOut";
            this.Cancel_CheckOut.Size = new System.Drawing.Size(388, 80);
            this.Cancel_CheckOut.TabIndex = 1;
            this.Cancel_CheckOut.Text = "Cancel Order";
            this.Cancel_CheckOut.UseVisualStyleBackColor = true;
            // 
            // Confirm_CheckOut
            // 
            this.Confirm_CheckOut.Location = new System.Drawing.Point(8, 229);
            this.Confirm_CheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm_CheckOut.Name = "Confirm_CheckOut";
            this.Confirm_CheckOut.Size = new System.Drawing.Size(384, 80);
            this.Confirm_CheckOut.TabIndex = 0;
            this.Confirm_CheckOut.Text = "Confirm Order";
            this.Confirm_CheckOut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CheckOut_Name,
            this.Column_CheckOut_Price});
            this.dataGridView1.Location = new System.Drawing.Point(913, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(327, 597);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_CheckOut_Name
            // 
            this.Column_CheckOut_Name.HeaderText = "Name";
            this.Column_CheckOut_Name.MinimumWidth = 6;
            this.Column_CheckOut_Name.Name = "Column_CheckOut_Name";
            this.Column_CheckOut_Name.Width = 125;
            // 
            // Column_CheckOut_Price
            // 
            this.Column_CheckOut_Price.HeaderText = "Price";
            this.Column_CheckOut_Price.MinimumWidth = 6;
            this.Column_CheckOut_Price.Name = "Column_CheckOut_Price";
            this.Column_CheckOut_Price.Width = 125;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Checkout";
            this.Size = new System.Drawing.Size(1327, 738);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Confirm_CheckOut;
        private System.Windows.Forms.Button Cancel_CheckOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Final_Price_Checkout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Final_Price_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CheckOut_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CheckOut_Price;
    }
}
