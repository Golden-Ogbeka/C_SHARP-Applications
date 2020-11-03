using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            this.listBoxSelected.Items.Clear();
            foreach (string item in this.chkListBoxValue.CheckedItems)
            {
                this.listBoxSelected.Items.Add(item.ToString());
            }
            for (int i = 0; i < this.chkListBoxValue.Items.Count; i++)
            {
                this.chkListBoxValue.SetItemChecked(i, false);
            }
        }
    }
}
