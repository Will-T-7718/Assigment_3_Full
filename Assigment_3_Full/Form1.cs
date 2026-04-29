using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_3_Full
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        // This can be reused for showing any UserControl
        private void ShowScreen(UserControl newScreen)
        {
            // Find existing controls and dispose them to free memory
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear(); // Clear the controls
            newScreen.Dock = DockStyle.Fill; // Set Dock to Fill
            pnlContent.Controls.Add(newScreen); // Add the UC to Pnl
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Checkout());

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Products());
        }
    }
}
