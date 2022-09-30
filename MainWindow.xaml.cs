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

namespace ISRPO_PR4_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        float a, b;
        int count;



        private void ButtonSbros_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void Button1Pl3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 1;
            calculate();
        }

        private void Button1Pl2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 2;
            calculate();
        }

        private void Button1Pl1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 3;
            calculate();
        }

        private void Button1M1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 4;
            calculate();
        }

        private void Button1M2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 5;
            calculate();
        }

        private void Button1M3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 6;
            calculate();
        }

        private void calculate()
        {
            
            switch (count)
            {
                case 1:
                    b = a + 3;
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + 2;
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a + 1;
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a - 1;
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a - 2;
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = a - 3;
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
