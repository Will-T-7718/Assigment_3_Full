namespace Assigment_3_Full
{
    partial class UC_Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Update_Inventory = new System.Windows.Forms.TextBox();
            this.btn_Update_Inventory = new System.Windows.Forms.Button();
            this.txt_Delete_Inventory = new System.Windows.Forms.TextBox();
            this.btn_Delete_Inventory = new System.Windows.Forms.Button();
            this.btn_Clear_Inventory = new System.Windows.Forms.Button();
            this.btn_Add_Inventory = new System.Windows.Forms.Button();
            this.Quantity_Inventory_Label = new System.Windows.Forms.Label();
            this.Brand_Inventory_Label = new System.Windows.Forms.Label();
            this.Name_Inventory_Label = new System.Windows.Forms.Label();
            this.Price_Inventory_Label = new System.Windows.Forms.Label();
            this.ID_Inventory_Label = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dgv_Inventory = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Column2,
            this.Column3,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(216, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(543, 419);
            this.dataGridView1.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Brand";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(211, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(168, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_Clear_Inventory);
            this.groupBox2.Controls.Add(this.btn_Add_Inventory);
            this.groupBox2.Controls.Add(this.Quantity_Inventory_Label);
            this.groupBox2.Controls.Add(this.Brand_Inventory_Label);
            this.groupBox2.Controls.Add(this.Name_Inventory_Label);
            this.groupBox2.Controls.Add(this.Price_Inventory_Label);
            this.groupBox2.Controls.Add(this.ID_Inventory_Label);
            this.groupBox2.Controls.Add(this.txt_Quantity);
            this.groupBox2.Controls.Add(this.txt_Brand);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Location = new System.Drawing.Point(10, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 427);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Update_Inventory);
            this.groupBox3.Controls.Add(this.btn_Update_Inventory);
            this.groupBox3.Controls.Add(this.txt_Delete_Inventory);
            this.groupBox3.Controls.Add(this.btn_Delete_Inventory);
            this.groupBox3.Location = new System.Drawing.Point(6, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txt_Update_Inventory
            // 
            this.txt_Update_Inventory.Location = new System.Drawing.Point(82, 88);
            this.txt_Update_Inventory.Name = "txt_Update_Inventory";
            this.txt_Update_Inventory.Size = new System.Drawing.Size(100, 22);
            this.txt_Update_Inventory.TabIndex = 3;
            // 
            // btn_Update_Inventory
            // 
            this.btn_Update_Inventory.Location = new System.Drawing.Point(7, 88);
            this.btn_Update_Inventory.Name = "btn_Update_Inventory";
            this.btn_Update_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_Inventory.TabIndex = 2;
            this.btn_Update_Inventory.Text = "Update";
            this.btn_Update_Inventory.UseVisualStyleBackColor = true;
            // 
            // txt_Delete_Inventory
            // 
            this.txt_Delete_Inventory.Location = new System.Drawing.Point(82, 43);
            this.txt_Delete_Inventory.Name = "txt_Delete_Inventory";
            this.txt_Delete_Inventory.Size = new System.Drawing.Size(100, 22);
            this.txt_Delete_Inventory.TabIndex = 1;
            // 
            // btn_Delete_Inventory
            // 
            this.btn_Delete_Inventory.Location = new System.Drawing.Point(6, 43);
            this.btn_Delete_Inventory.Name = "btn_Delete_Inventory";
            this.btn_Delete_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_Inventory.TabIndex = 0;
            this.btn_Delete_Inventory.Text = "Delete";
            this.btn_Delete_Inventory.UseVisualStyleBackColor = true;
            this.btn_Delete_Inventory.Click += new System.EventHandler(this.btn_Delete_Inventory_Click);
            // 
            // btn_Clear_Inventory
            // 
            this.btn_Clear_Inventory.Location = new System.Drawing.Point(110, 245);
            this.btn_Clear_Inventory.Name = "btn_Clear_Inventory";
            this.btn_Clear_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_Inventory.TabIndex = 11;
            this.btn_Clear_Inventory.Text = "Clear";
            this.btn_Clear_Inventory.UseVisualStyleBackColor = true;
            this.btn_Clear_Inventory.Click += new System.EventHandler(this.btn_Clear_Inventory_Click);
            // 
            // btn_Add_Inventory
            // 
            this.btn_Add_Inventory.Location = new System.Drawing.Point(19, 245);
            this.btn_Add_Inventory.Name = "btn_Add_Inventory";
            this.btn_Add_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Inventory.TabIndex = 10;
            this.btn_Add_Inventory.Text = "Add";
            this.btn_Add_Inventory.UseVisualStyleBackColor = true;
            this.btn_Add_Inventory.Click += new System.EventHandler(this.Add_Inventory_Button_Click);
            // 
            // Quantity_Inventory_Label
            // 
            this.Quantity_Inventory_Label.AutoSize = true;
            this.Quantity_Inventory_Label.Location = new System.Drawing.Point(25, 202);
            this.Quantity_Inventory_Label.Name = "Quantity_Inventory_Label";
            this.Quantity_Inventory_Label.Size = new System.Drawing.Size(55, 16);
            this.Quantity_Inventory_Label.TabIndex = 9;
            this.Quantity_Inventory_Label.Text = "Quantity";
            // 
            // Brand_Inventory_Label
            // 
            this.Brand_Inventory_Label.AutoSize = true;
            this.Brand_Inventory_Label.Location = new System.Drawing.Point(25, 158);
            this.Brand_Inventory_Label.Name = "Brand_Inventory_Label";
            this.Brand_Inventory_Label.Size = new System.Drawing.Size(43, 16);
            this.Brand_Inventory_Label.TabIndex = 8;
            this.Brand_Inventory_Label.Text = "Brand";
            // 
            // Name_Inventory_Label
            // 
            this.Name_Inventory_Label.AutoSize = true;
            this.Name_Inventory_Label.Location = new System.Drawing.Point(25, 121);
            this.Name_Inventory_Label.Name = "Name_Inventory_Label";
            this.Name_Inventory_Label.Size = new System.Drawing.Size(44, 16);
            this.Name_Inventory_Label.TabIndex = 7;
            this.Name_Inventory_Label.Text = "Name";
            // 
            // Price_Inventory_Label
            // 
            this.Price_Inventory_Label.AutoSize = true;
            this.Price_Inventory_Label.Location = new System.Drawing.Point(25, 80);
            this.Price_Inventory_Label.Name = "Price_Inventory_Label";
            this.Price_Inventory_Label.Size = new System.Drawing.Size(38, 16);
            this.Price_Inventory_Label.TabIndex = 6;
            this.Price_Inventory_Label.Text = "Price";
            // 
            // ID_Inventory_Label
            // 
            this.ID_Inventory_Label.AutoSize = true;
            this.ID_Inventory_Label.Location = new System.Drawing.Point(25, 43);
            this.ID_Inventory_Label.Name = "ID_Inventory_Label";
            this.ID_Inventory_Label.Size = new System.Drawing.Size(20, 16);
            this.ID_Inventory_Label.TabIndex = 5;
            this.ID_Inventory_Label.Text = "ID";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(94, 199);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 22);
            this.txt_Quantity.TabIndex = 4;
            // 
            // txt_Brand
            // 
            this.txt_Brand.Location = new System.Drawing.Point(94, 155);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(100, 22);
            this.txt_Brand.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(94, 114);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(94, 77);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 22);
            this.txt_Price.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(94, 40);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // dgv_Inventory
            // 
            this.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Price_Column,
            this.Name_Column,
            this.Brand_Column,
            this.Quantity_Column});
            this.dgv_Inventory.Location = new System.Drawing.Point(216, 22);
            this.dgv_Inventory.Name = "dgv_Inventory";
            this.dgv_Inventory.RowHeadersWidth = 51;
            this.dgv_Inventory.Size = new System.Drawing.Size(669, 421);
            this.dgv_Inventory.TabIndex = 1;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.MinimumWidth = 6;
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.Width = 125;
            // 
            // Price_Column
            // 
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.MinimumWidth = 6;
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.Width = 125;
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Name";
            this.Name_Column.MinimumWidth = 6;
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.Width = 125;
            // 
            // Brand_Column
            // 
            this.Brand_Column.HeaderText = "Brand";
            this.Brand_Column.MinimumWidth = 6;
            this.Brand_Column.Name = "Brand_Column";
            this.Brand_Column.Width = 125;
            // 
            // Quantity_Column
            // 
            this.Quantity_Column.HeaderText = "Quantity";
            this.Quantity_Column.MinimumWidth = 6;
            this.Quantity_Column.Name = "Quantity_Column";
            this.Quantity_Column.Width = 125;
            // 
            // UC_Inventory
            // 
            this.Controls.Add(this.dgv_Inventory);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(922, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ID_Inventory_Label;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView dgv_Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Column;
        private System.Windows.Forms.Button btn_Add_Inventory;
        private System.Windows.Forms.Label Quantity_Inventory_Label;
        private System.Windows.Forms.Label Brand_Inventory_Label;
        private System.Windows.Forms.Label Name_Inventory_Label;
        private System.Windows.Forms.Label Price_Inventory_Label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Delete_Inventory;
        private System.Windows.Forms.Button btn_Delete_Inventory;
        private System.Windows.Forms.Button btn_Clear_Inventory;
        private System.Windows.Forms.Button btn_Update_Inventory;
        private System.Windows.Forms.TextBox txt_Update_Inventory;
    }
}
