using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRST_GUI_LECTURE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            this.Text = "Hello this is for class";
        }

        private void PracticalButton_Click(object sender, EventArgs e)
        {
            this.Text = "This is for Practical";
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
