//Grade iD: R2217
//CIS 199 Section: 02
//Due date: 02/27/2022
//The purpose of this program is to calculate whether students should be accepted/rejected based on GPA and test scores.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        //running total of number of students who were either accepted or rejected
        int totalAccepted = 0;
        int totalRejected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //button calculates whether student is accepted or rejected based on input
        private void button1_Click(object sender, EventArgs e)
        {
            //variables for input of gpa and test scores
            float gpa;
            int testScore;


            {
                //displays whether or not gpa input is valid
                if (float.TryParse(gpaTB.Text, out gpa))
                    if (gpa <= 4.0 && gpa >= 0.0)
                    {
                        MessageBox.Show("Valid GPA. ");
                    }
                    else
                    {
                        MessageBox.Show("Enter valid GPA. ");
                    }

                //displays whether or not test score input is valid
                if (int.TryParse(testScoreTB.Text, out testScore))
                    if (testScore >= 0 && testScore <= 100)
                    {
                        MessageBox.Show("Valid Test Score. ");
                    }
                    else
                    {
                        MessageBox.Show("Enter valid score. ");
                    }
                {
                    //displays if student is accepyted or rejected based on input
                    if (gpa >= 3.0 && testScore >= 60 || (gpa < 3.0 && testScore >= 80))
                    {
                        MessageBox.Show("Accepted. "); //displays message accepted
                        totalAccepted++; //adds to running total if accepted
                        countAccepted.Text = $"{totalAccepted}"; //outputs number of accepted
                    }
                    else
                    {
                        MessageBox.Show("Rejected. "); //displays message rejected
                        totalRejected++; //adds to count if rejected
                        countRejected.Text = $"{totalRejected}"; //outputs number of rejected
                    }
                }
            }
        }
    }
}

