using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // handler for numeric buttons
        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
                result.Clear();

            Button b = (Button)sender;
            result.Text += b.Text;
        }


        // handler for CE button
        private void btnCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        // handler for operator (+-/*) buttons
        private void operator_click(object sender, EventArgs e)
        {

        }
    }
}
