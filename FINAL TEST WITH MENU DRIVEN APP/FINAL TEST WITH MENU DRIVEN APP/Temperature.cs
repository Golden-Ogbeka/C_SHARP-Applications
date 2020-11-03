using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FINAL_TEST_WITH_MENU_DRIVEN_APP
{
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int celcius;
            celcius = Convert.ToInt32(txtinput.Text);
            int fahrenheit = ((9 / 5) * celcius) + 32;
            txtoutput.Text = fahrenheit.ToString();
        }
    }
}
