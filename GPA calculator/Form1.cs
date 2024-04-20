using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private double gpa(double d)
        {

            if (d >= 85 && d <= 100)
                return 4;
            else if (d >= 80)
                return 3.66;
            else if (d >= 75)
                return 3.33;
            else if (d >= 70)
                return 3.00;
            else if (d >= 67)
                return 2.66;
            else if (d >= 64)
                return 2.33;
            else if (d >= 60)
                return 2.00;
            else if (d >= 57)
                return 1.66;
            else if (d >= 53)
                return 1.33;
            else if (d >= 50)
                return 1;
            else
                return 0;


        }
        private void input_marks(object sender, EventArgs e)
        {
        


        }

        private void calculater_result(object sender, EventArgs e)
        {
                Button button = (Button)sender;

            //for numbers 
            double m1, m2, m3, m4,m5,m6;
            //for gpa individualy
            double g1, g2, g3, g4, g5, g6,total_gpa,t_credits,final_gpa;
            if(button.Text=="Enter")
            {
                m1 = Convert.ToDouble(marks1.Text);
                g1 = gpa(m1);
                m2 = Convert.ToDouble(marks2.Text);
                g2 = gpa(m2);
                m3 = Convert.ToDouble(marks3.Text);
                g3 = gpa(m3);
                m4 = Convert.ToDouble(marks4.Text);
                g4 = gpa(m4);
                m5 = Convert.ToDouble(marks5.Text);
                g5 = gpa(m5);
                m6 = Convert.ToDouble(marks6.Text);
                g6 = gpa(m6);
                textBox2.Text = "";
                t_credits = Convert.ToDouble(credit1.Text) + Convert.ToDouble(credits2.Text) + Convert.ToDouble(credit3.Text) + Convert.ToDouble(credit4.Text) + Convert.ToDouble(credit5.Text) + Convert.ToDouble(credit6.Text);
                total_gpa = (g1 * Convert.ToDouble(credit1.Text)) + (g2 * Convert.ToDouble(credits2.Text)) + (g3 * Convert.ToDouble(credit3.Text)) + (g4 * Convert.ToDouble(credit4.Text)) + (g5 * Convert.ToDouble(credit5.Text)) + (g6 * Convert.ToDouble(credit6.Text));
                final_gpa = (total_gpa / t_credits);
                textBox2.Text = (final_gpa).ToString();
            }
            else if(button.Text=="Clean")
            {
                marks1.Text = marks2.Text = marks3.Text = marks4.Text = marks5.Text = marks6.Text = "0";
                credit1.Text = credits2.Text = credit3.Text = credit4.Text = credit5.Text = credit6.Text = "0";
               textBox2.Text = "0";

            }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void credits2_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit3_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit4_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit5_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit1_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks2_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks3_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks4_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks5_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
