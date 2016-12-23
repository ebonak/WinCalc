using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* this is based on a YouTube Tutorial
 * https://www.youtube.com/watch?v=Is1EHXFhEe4
 * 
 * e.bonakdarian dec 2016
 */

namespace WinCalc
{
    public partial class Form1 : Form
    {
        double value = 0.0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        // handler for numeric buttons
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text += b.Text;
        }


        // handler for CE button
        private void btnCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        // handler for operator (+,-,/,*) buttons
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    MessageBox.Show("Invalid Operator!");
                    break;
            }
        }

        // the C button
        private void btnC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
