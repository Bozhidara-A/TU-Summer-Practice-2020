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
    
    /*public enum Operator 
    { 
        None, 
        +,
        -, 
        *, 
        /
    };*/
    public partial class MainWindow : Window
    {
        decimal a, b;
        string storageVar = "";
        decimal result;
        string operators = "0";
        
        public MainWindow()
        {
            InitializeComponent();
        }

       private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text = txtBox.Text + button.Content.ToString();
            storageVar += button.Content.ToString();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (operators.Equals("0"))
            {
                if (txtBox.Text.Equals("")||txtBox.Text.Equals("-"))
                {
                    a = 0;
                    storageVar += "0";
                }
                else
                {
                    a = Convert.ToDecimal(txtBox.Text);
                }
                txtBox.Text = "";
                operators = button.Content.ToString();
                storageVar += button.Content.ToString();
            }
            /*if (operators.Equals("1"))
            {
               
            }*/
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text.Equals(""))
            {
                txtBox.Text += "-";
                storageVar += "-";
            }
            else
            {
                if (operators.Equals("0"))
                {
                    if (txtBox.Text.Equals("-"))
                    {
                        a = 0;
                        storageVar += "0";
                    }
                    else
                    {
                        a = Convert.ToDecimal(txtBox.Text);
                    }
                        txtBox.Text = "";
                        operators = "-";
                        storageVar += "-";
                   
                }
            }

        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!txtBox.Text.Contains(","))
            {
                if (txtBox.Text.Equals(""))
                {
                    txtBox.Text += "0,";
                    storageVar += "0,";
                }
                else
                {
                    txtBox.Text = txtBox.Text + ",";
                    storageVar += ",";
                }
            }
            
        }
               
        private void ClrBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "";
            storeBox.Text = "";
            operators = "0";
            a = 0;
            b = 0;
            storageVar = "";
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
                    b = Convert.ToDecimal(txtBox.Text);
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
                    result = Convert.ToDecimal(txtBox.Text);
                }
            }
            txtBox.Text = result.ToString();
            storeBox.Text = storageVar;
            operators = "0";
        }       
    }
}
