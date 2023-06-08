using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text !="")
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);

                float result = number1 + number2;
                resultLabel.Text = "Addition result: " + result.ToString();
                resultLabel.Visible = true;

            }
            else
            {
                MessageBox.Show("Please enter the numbers first!!");
            }
            
        }

        private void subtructButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);

                float result = number1 - number2;
                resultLabel.Text = "Subtract result: " + result.ToString();
                resultLabel.Visible = true;

            }
            else
            {
                MessageBox.Show("Please enter the numbers first!!");
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);

                float result = number1 * number2;
                resultLabel.Text = "Multiplication result: " + result.ToString();
                resultLabel.Visible = true;

            }
            else
            {
                MessageBox.Show("Please enter the numbers first!!");
            }

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);

                float result = number1 / number2;
                resultLabel.Text = "Division result: " + result.ToString();
                resultLabel.Visible = true;

            }
            else
            {
                MessageBox.Show("Please enter the numbers first!!");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            textBox1.Clear();
            textBox2.Clear();
            resultLabel.Visible = false;
            textBox1.Focus();
        }
    }
}
