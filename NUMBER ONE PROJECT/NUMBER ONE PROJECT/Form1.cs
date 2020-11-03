using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NUMBER_ONE_PROJECT
{
    public partial class Form1 : Form
    {
        List<double> values;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = 0.00;
            double sumForMean = 0.00, bigSum = 0.00, mean = 0.00;
            double stdDev = 0.00;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter a value","Invalid");
                return;
            }
            try
            {
                value = double.Parse(textBox1.Text);
                values.Add(value);
                ShowValues();
                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.", "Error");
            }
            for (int i = 0; i < values.Count; i++)
                sumForMean += values[i];
            mean = sumForMean / values.Count;
            for (int i = 0; i < values.Count; i++)
                bigSum += Math.Pow(values[i] - mean, 2);
            stdDev = Math.Sqrt(bigSum / (values.Count - 1));
            textBox2.Text = mean.ToString("F");
            textBox3.Text = stdDev.ToString("F");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            values = new List<double>();
        }
        void ShowValues()
        {
            //listBox1.Items.Clear();
            //for (int i = 0; i < values.Count; i++)
            //    listBox1.Items.Add(values[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            values.Clear();
            listBox1.Items.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
