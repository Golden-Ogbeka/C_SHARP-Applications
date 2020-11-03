using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starting_radiobox_and_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string output;
            output = "Occupation: " + (string)(this.chkProgrammer.Checked ? "Programmer" : "Not a programmer") + "\r\n";
            output += "Sex: " + (string)(this.radFemale.Checked ? "Female" : "Male") + "\r\n";
            this.txtReport.Text = output;
        }

        private void chkProgrammer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
