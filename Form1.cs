using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WsgCalc
{
    public partial class Form1 : Form
    {
        private SoundPlayer player = new SoundPlayer(Properties.Resources.CalculatorSong);
        private double firstNumber;
        private double secondNumber;
        private bool changeStatus = false;
        private bool musicPlay = false;
        private char sign;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetNumber_Click(object sender, EventArgs e)
        {
            if (changeStatus)
            {
                try
                {
                    firstNumber = double.Parse(resultTextBox.Text);
                    resultTextBox.Text = "";
                    changeStatus = !changeStatus;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    resultTextBox.Clear();
                }
            }
            if (resultTextBox.Text.Contains("Error"))
                resultTextBox.Clear();

            resultTextBox.Text += ((Button)sender).Text;
        }
        private void GetOperator(object sender, EventArgs e)
        {
            if (resultTextBox.TextLength > 0)
            {
                try
                {
                    sign = char.Parse(((Button)sender).Text);
                    changeStatus = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    resultTextBox.Clear();
                }
            }
        }
        private void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = Math.Pow(double.Parse(resultTextBox.Text), 2).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                resultTextBox.Clear();
            }
        }
    
        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = double.Parse(resultTextBox.Text);
                resultTextBox.Text = MathCalculations.CalculateResult(firstNumber, secondNumber, sign);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void factorialButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = MathCalculations.Factorial(int.Parse(resultTextBox.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message +
                    Environment.NewLine + "You must enter an integer");
                resultTextBox.Clear();
            }
        }
        private void soundButton_Click(object sender, EventArgs e)
        {
            if (musicPlay)
            {
                soundButton.BackgroundImage = Properties.Resources.musicOFF;
                player.Stop();
                musicPlay = !musicPlay;
            }
            else
            {
                soundButton.BackgroundImage = Properties.Resources.musicON;
                player.Play();
                musicPlay = true;
            }
        }
        private void changeSymbolbutton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Contains('-'))
            {
                resultTextBox.Text = resultTextBox.Text.Remove(0, 1);
            }
            else
            {
                resultTextBox.Text = "-" + resultTextBox.Text;
            }
        }
        private void clearLastElement_Click(object sender, EventArgs e)
        {
            if (resultTextBox.TextLength > 0)
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
        }
        private void dotButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.TextLength > 0)
                resultTextBox.Text += ".";
        }
        private void clearTextBoxButton_Click(object sender, EventArgs e) => resultTextBox.Clear();

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = Math.Sqrt(double.Parse(resultTextBox.Text)).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                resultTextBox.Clear();
            }
        }
    }
}
