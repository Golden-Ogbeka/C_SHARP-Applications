using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APPLICATION_FOR_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure", "Exit?", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Form form = new New_Form();
            form.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no help available now", "Help?");
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure", "Exit?", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text,new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(0, 0));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.LoadFile(@"C:\Users\Nedlog\Desktop\name.txt",RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\Nedlog\Desktop\name.txt", RichTextBoxStreamType.PlainText);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Users\Nedlog\Desktop\COURSES\CSC221\name.txt", RichTextBoxStreamType.PlainText);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\Nedlog\Desktop\COURSES\CSC221\name.txt", RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure", "Exit?", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
