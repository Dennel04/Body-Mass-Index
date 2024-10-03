using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weightInPounds = Convert.ToDouble(textBox1.Text);
                double heightInInches = Convert.ToDouble(textBox2.Text);

                double weightInKg = weightInPounds * 0.453592;
                double heightInMeters = heightInInches * 0.0254;

                double bmi = weightInKg / (heightInMeters * heightInMeters);

                string status;
                if (bmi < 18.5)
                {
                    status = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    status = "Optimal";
                }
                else
                {
                    status = "Overweight";
                }

                label3.Text = $"BMI: {bmi:F2}\nStatus: {status}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for weight and height.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}