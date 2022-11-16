using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caclulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        char op = ' ';
        bool lastClick = false;

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            txtInputOutput.Content = "";
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            string equation = (string)txtInputOutput.Content;

            txtInputOutput.Content = equation.Remove(equation.IndexOf(equation.Last(), equation.Length - 1));
        }

        private void btNum_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            string num = (string)bt.Content;

            if (lastClick)
            {
                txtInputOutput.Content = num;
                lastClick = false;
            }
            else
            {
                txtInputOutput.Content = txtInputOutput.Content + num;
            }
            
        }

        private void btEquation_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            string symbol = (string)bt.Content;
            string equation = (string)txtInputOutput.Content;

            char lastChar = equation.Last();

            if (char.IsDigit(lastChar))
            {
                txtInputOutput.Content = equation + symbol;
            }
            else
            {
                txtInputOutput.Content = equation.Replace(lastChar, char.Parse(symbol));
            }

            op = char.Parse(symbol);
            lastClick = false;
        }

        private void btSign_Click(object sender, RoutedEventArgs e)
        {
            string equation = (string)txtInputOutput.Content;

            if (op == ' ')
            {
                float firstNum = float.Parse(equation);
                firstNum = firstNum * -1;

                equation = firstNum.ToString();

                txtInputOutput.Content = equation;
            }
            else
            {
                int opLoc = equation.IndexOf(op);

                if (opLoc != equation.Length && equation.Last() != op)
                {
                    float origNum = float.Parse(equation.Substring(opLoc + 1));
                    float newNum = origNum * -1;

                    equation = equation.Replace(origNum.ToString(), newNum.ToString());

                    txtInputOutput.Content = equation;
                }
            }
        }

        private void btDecimal_Click(object sender, RoutedEventArgs e)
        {
            string equation = (string)txtInputOutput.Content;

            if (!equation.Contains('.'))
            {
                if (equation == "")
                {
                    txtInputOutput.Content = "0.";
                }
                else
                {
                    txtInputOutput.Content = txtInputOutput.Content + ".";
                }
            }
            else
            {
                int opLoc = equation.IndexOf(op);

                if (op != ' ' && opLoc != equation.Length)
                {
                    char equationLast = equation.Last();
                    if (equationLast == op)
                    {
                        txtInputOutput.Content = equation + "0.";
                    }
                    else
                    {
                        txtInputOutput.Content = equation + ".";
                    }
                }

            }            
        }

        private void btEqual_Click(object sender, RoutedEventArgs e)
        {
            string equation = (string)txtInputOutput.Content;

            int opLoc = equation.IndexOf(op);

            if (op != ' ' && opLoc != equation.Length)
            {
                float firstNum = float.Parse(equation.Substring(0, opLoc));
                float secondNum = float.Parse(equation.Substring(opLoc + 1));

                txtInputOutput.Content = Calculate(firstNum, secondNum, op);
                lastClick = true;
            }
        }

        public string Calculate(float fOne, float fTwo, char op)
        {
            float answer = 0;
            string strAnswer = "";

            if(op == '+')
            {
                answer = fOne + fTwo;
            } 
            else if (op == '-')
            {
                answer = fOne - fTwo;
            }
            else if (op == '*')
            {
                answer = fOne * fTwo;
            }
            else if (op == '/')
            {
                if (fTwo == 0)
                {
                    string fail = "Error!";
                    return fail;
                }
                else
                {
                    answer = fOne / fTwo;
                }
            }
            else if (op == '%')
            {
                answer = fOne % fTwo;
            }
            else
            {
                return null;
            }

            strAnswer = answer.ToString("0.000");

            return strAnswer;
        }
    }
}
