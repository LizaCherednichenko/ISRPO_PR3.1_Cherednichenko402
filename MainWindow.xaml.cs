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


        private void ButtonSbros_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button1Pl3_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button1Pl2_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button1Pl1_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button1M1_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            a = a - 1;
        }
    }
}
