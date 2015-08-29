using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorWinApp
{
    public partial class CalculatorUI : Form
    {
        private double firstNumber;
        private double secondNumber;

        public CalculatorUI()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstTextBox.Text);
            secondNumber = Convert.ToDouble(secondTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstTextBox.Text);
            secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(firstNumber - secondNumber);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstTextBox.Text);
            secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(firstNumber * secondNumber);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstTextBox.Text);
            secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(firstNumber / secondNumber);
        }
    }
}
