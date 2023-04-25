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

namespace ZAD3
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
        public void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = double.Parse(txtRadius.Text);
                double area = CircleS(radius);
                txtArea.Text = area.ToString();
                statusText.Text = "";
            }
            catch (FormatException)
            {
                statusText.Text = "Ошибка: неверный формат ввода";
            }
            catch (Exception ex)
            {
                statusText.Text = $"Ошибка: {ex.Message}";
            }
        }

            public static double CircleS(double R)
            {
                const double PI = 3.14;
                return PI * Math.Pow(R,2);
            }
    }
}
