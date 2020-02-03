using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WsgCalc
{
    public class MathCalculations
    {

        public static string CalculateResult(double ftnum, double secnum, char sign)
        {
            string result;

            switch (sign)
            {
                case '+':
                    result = (ftnum + secnum).ToString();
                    break;
                case '-':
                    result = (ftnum - secnum).ToString();
                    break;

                case '*':
                    result = (ftnum * secnum).ToString();
                    break;

                case '÷':
                    if (secnum == 0)
                    {
                        MessageBox.Show("You Can not Divide by ZERO!");
                        result = "";
                    }
                    else
                    {
                        result = (ftnum / secnum).ToString();
                    }
                    break;
                default:
                    result = "Something went wrong!";
                    break;
            }
            return result;
        }
        public static string Factorial(int num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result.ToString();
        }
    }
}
