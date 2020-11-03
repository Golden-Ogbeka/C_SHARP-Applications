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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TemperatureStrip_Click(object sender, EventArgs e)
        {
            double celcius;
            celcius = Convert.ToDouble(txtinput.Text);
            double fahrenheit = ((9 / 5) * celcius) + 32;
            txtoutput.Text = fahrenheit.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentGpaStrip_Click(object sender, EventArgs e)
        {
            double score1, score2, score3, score4, score5;
            score1 = Convert.ToDouble(txtinput1.Text);
            score2 = Convert.ToDouble(txtinput2.Text);
            score3 = Convert.ToDouble(txtinput3.Text);
            score4 = Convert.ToDouble(txtinput4.Text);
            score5 = Convert.ToDouble(txtinput5.Text);
            double gradepoint1, gradepoint2, gradepoint3, gradepoint4, gradepoint5;
          //for score 1
            if (score1 > 70)
            {
                gradepoint1 = 5;
            }
            else if (score1 >= 60 && score1 <= 69)
            {
                gradepoint1 = 4;
            }
            else if (score1 >= 50 && score1 <= 59)
            {
                gradepoint1 = 3;
            }
            else if (score1 >= 45 && score1 <= 49)
            {
                gradepoint1 = 2;
            }
            else
            {
                gradepoint1 = 0;
            }
            //for score 2
            if (score2 > 70)
            {
                gradepoint2 = 5;
            }
            else if (score2 >= 60 && score2 <= 69)
            {
                gradepoint2 = 4;
            }
            else if (score2 >= 50 && score2 <= 59)
            {
                gradepoint2 = 3;
            }
            else if (score2 >= 45 && score2 <= 49)
            {
                gradepoint2 = 2;
            }
            else
            {
                gradepoint2 = 0;
            }
            //for score3
            if (score3 > 70)
            {
                gradepoint3 = 5;
            }
            else if (score3 >= 60 && score3 <= 69)
            {
                gradepoint3 = 4;
            }
            else if (score3 >= 50 && score3 <= 59)
            {
                gradepoint3 = 3;
            }
            else if (score3 >= 45 && score3 <= 49)
            {
                gradepoint3 = 2;
            }
            else
            {
                gradepoint3 = 0;
            }
            //for score 4
            if (score4 > 70)
            {
                gradepoint4 = 5;
            }
            else if (score4 >= 60 && score4 <= 69)
            {
                gradepoint4 = 4;
            }
            else if (score4 >= 50 && score4 <= 59)
            {
                gradepoint4 = 3;
            }
            else if (score4 >= 45 && score4 <= 49)
            {
                gradepoint4 = 2;
            }
            else
            {
                gradepoint4 = 0;
            }
            //for score5
            if (score5 > 70)
            {
                gradepoint5 = 5;
            }
            else if (score5 >= 60 && score5 <= 69)
            {
                gradepoint5 = 4;
            }
            else if (score5 >= 50 && score5 <= 59)
            {
                gradepoint5 = 3;
            }
            else if (score5 >= 45 && score5 <= 49)
            {
                gradepoint5 = 2;
            }
            else
            {
                gradepoint5 = 0;
            }
            double gpa = ((gradepoint1 * 3) + (gradepoint2 * 2) + (gradepoint3 * 4) + (gradepoint4 * 3) + (gradepoint5 * 2)) / (14);
            txtGPAoutput.Text = gpa.ToString();
        }


    }
}
