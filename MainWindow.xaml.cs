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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b;
       // string storageVar;
        double result;
        string operators = "0";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
            //storageVar += "0";
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!txtBox.Text.Contains("."))
            {
                if (txtBox.Text.Equals(""))
                {
                    txtBox.Text += "0,";
                }
                else
                {
                    txtBox.Text = txtBox.Text + ",";
                }
            }
            
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "1";
            //storageVar += "1";
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "2";
            //storageVar += "2";
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "3";
           // storageVar += "3";
        }
        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "4";
           // storageVar += "4";
        }
        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "5";
           // storageVar += "5";
        }
        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "6";
           // storageVar += "6";
        }
        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "7";
            //storageVar += "7";
        }
        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "8";
            //storageVar += "8";
        }
        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + "9";
            //storageVar += "9";
        }

        private void ClrBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "";
            operators = "0";
            a = 0;
            b = 0;
        }

        private void SumBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operators.Equals("0"))
            {
                if (txtBox.Text.Equals(""))
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtBox.Text);
                }
                txtBox.Text = "";
                operators = "+";
            }    
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            /*if (txtBox.Text.Equals(""))
            {
                txtBox.Text = "0-";
            }
            if (!(txtBox.Text.Contains("+") || txtBox.Text.Contains("-") || txtBox.Text.Contains("*") || txtBox.Text.Contains("/")))
            {
                txtBox.Text = txtBox.Text + "-";
            }*/
            if (operators.Equals("0"))
            {
                if (txtBox.Text.Equals(""))
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtBox.Text);
                }
                txtBox.Text = "";
                operators = "-";
            }
        }

        private void MultiplBtn_Click(object sender, RoutedEventArgs e)
        {
            /* if (txtBox.Text.Equals(""))
             {
                 txtBox.Text = "0*";
             }
             if (!(txtBox.Text.Contains("+") || txtBox.Text.Contains("-") || txtBox.Text.Contains("*") || txtBox.Text.Contains("/")))
             {
                 txtBox.Text = txtBox.Text + "*";
             }*/
            if (operators.Equals("0"))
            {
                if (txtBox.Text.Equals(""))
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtBox.Text);
                }
                txtBox.Text = "";
                operators = "*";
            }
        }

        private void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            /*if (txtBox.Text.Equals(""))
            {
                txtBox.Text = "0/";
            }
            if (!(txtBox.Text.Contains("+") || txtBox.Text.Contains("-") || txtBox.Text.Contains("*") || txtBox.Text.Contains("/")))
            {
                txtBox.Text = txtBox.Text + "/";
            }*/
            if (operators.Equals("0"))
            {
                if (txtBox.Text.Equals(""))
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtBox.Text);
                }
                txtBox.Text = "";
                operators = "/";
            }
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!operators.Equals("0"))
            {
                if (txtBox.Text.Equals(""))
                {
                    b = 0;
                }
                else
                {
                    b = Convert.ToDouble(txtBox.Text);
                }
                if (operators.Equals("+"))
                {
                    result = a + b;
                }
                if (operators.Equals("-"))
                {
                    result = a - b;
                }
                if (operators.Equals("*"))
                {
                    result = a * b;
                }
                if (operators.Equals("/"))
                {
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by 0.");
                        result = 0;
                    }
                }
            }
            else
            {
                if (txtBox.Text.Equals(""))
                {
                    result = 0;
                }
                else
                {
                    result = Convert.ToDouble(txtBox.Text);
                }
            }
            txtBox.Text = result.ToString();
            operators = "0";
        }


       
    }
}
