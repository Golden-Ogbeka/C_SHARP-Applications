using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temperature;
            temperature = Convert.ToInt32(txtTemp.Text);
            if (temperature< 50) 
            {
                this.txtPrice.Text = "Don't bother";
            }
            else if (temperature >=50 && temperature<=60)
            {
                this.txtPrice.Text = "20 naira";
            }
            else if (temperature >= 61 && temperature <= 70)
            {
                this.txtPrice.Text = "25 naira";
            }
            else if (temperature >= 71 && temperature <= 80)
            {
                this.txtPrice.Text = "35 naira";
            }
            else if (temperature >= 81 && temperature <= 85)
            {
                this.txtPrice.Text = "40 naira";
            }
            else if (temperature >= 86 && temperature <= 90)
            {
                this.txtPrice.Text = "50 naira";
            }
            else if (temperature >= 91 && temperature <= 95)
            {
                this.txtPrice.Text = "55 naira";
            }
            else if (temperature >= 96 && temperature <= 100)
            {
                this.txtPrice.Text = "65 naira";
            }
            else
            {
                this.txtPrice.Text = "75 naira";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
