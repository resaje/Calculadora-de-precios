using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_precios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.NumerosDecimales(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                decimal precio = Convert.ToDecimal(textBox1.Text);
                decimal precio5, precio10, precio15, precio20, precio45;
                precio5 = decimal.Multiply(precio, (decimal)1.05);
                label11.Text = "$ "+Convert.ToString(decimal.Round(precio5, 0, MidpointRounding.AwayFromZero));
                precio10 = decimal.Multiply(precio, (decimal)1.1);
                label10.Text= "$ " + Convert.ToString(decimal.Round(precio10, 0, MidpointRounding.AwayFromZero));
                precio15 = decimal.Multiply(precio, (decimal)1.15);
                label9.Text= "$ " + Convert.ToString(decimal.Round(precio15, 0, MidpointRounding.AwayFromZero));
                precio20 = decimal.Multiply(precio, (decimal)1.2);
                label8.Text= "$ " + Convert.ToString(decimal.Round(precio20, 0, MidpointRounding.AwayFromZero));
                precio45 = decimal.Multiply(precio, (decimal)1.45);
                label7.Text= "$ " + Convert.ToString(decimal.Round(precio45, 0, MidpointRounding.AwayFromZero));
                precio5 = decimal.Multiply(precio5, (decimal)1.16);
                label17.Text= "$ " + Convert.ToString(decimal.Round(precio5, 0, MidpointRounding.AwayFromZero));
                precio10 = decimal.Multiply(precio10, (decimal)1.16);
                label16.Text = "$ " + Convert.ToString(decimal.Round(precio10, 0, MidpointRounding.AwayFromZero));
                precio15 = decimal.Multiply(precio15, (decimal)1.16);
                label15.Text = "$ " + Convert.ToString(decimal.Round(precio15, 0, MidpointRounding.AwayFromZero));
                precio20 = decimal.Multiply(precio20, (decimal)1.16);
                label14.Text = "$ " + Convert.ToString(decimal.Round(precio20, 0, MidpointRounding.AwayFromZero));
                precio45 = decimal.Multiply(precio45, (decimal)1.16);
                label13.Text = "$ " + Convert.ToString(decimal.Round(precio45, 0, MidpointRounding.AwayFromZero));
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.Text.Length;
                }
            }
        }
    }
}
