using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3
{
    public partial class Form1 : Form
    {

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string weightText = maskedTextBox1.Text.Trim(); 
            string heightText = maskedTextBox2.Text.Trim(); 

            int weight;
            int height;

            if (int.TryParse(weightText, out weight) && int.TryParse(heightText, out height))
            {
                float heightInMeters = height / 100f;

                float bmi = weight / (heightInMeters * heightInMeters);

                string status;
                if (bmi < 18.5)
                {
                    status = "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    status = "Normal weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    status = "Overweight";
                }
                else
                {
                    status = "Obese";
                }

                label5.Text = $"BMI: {bmi:F2}"; 
                label4.Text = $"Status: {status}"; 
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for weight and height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            
            
        
    

