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

namespace Prakt__6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
public partial class MainWindow : Window
    {
        static int f(int x)
        {
            return x % 10;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtNumber1.Text);
            int z;
            int b = int.Parse(txtNumber2.Text);
            z = f(a) + f(b);
            lblResult.Content = $"Y={z:N3}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
