using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CLASSWORK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string output;
            //conactnate all the values together
            output = "Name: " + this.txtName.Text + "\r\n";
            output += "Address: " + this.txtAddress.Text + "\r\n";
            output += "Occupation: " + this.txtoccupation.Text + "\r\n";
            output += "Age: " + this.txtAge.Text;
            this.txtOutput.Text = output;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name: Your name\r\n " + "Address: Your address\r\n " + "Occupation: only allowed value is Programmer\r\n "+"Age: Your age" ;
            this.txtOutput.Text = output;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
