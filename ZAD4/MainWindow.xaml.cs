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

namespace ZAD4
{
    class Task //Метод
    {
        public int a;
        public int b;
        public int h;
        private int y;
        public Task(int x, int y, int n)
        {
            a = x; b = y; h = n;
        }

        public void Tasker() //Функция метода
        {
            for (int x = a; x <= b; x += h)
            {
                if (x < 0)
                {
                    Console.WriteLine(y = 0);
                }
                if (x > 0 && x != 1)
                {
                    Console.WriteLine(y = (int)Math.Pow(x, 2));
                }
                if (x == 1)
                {
                    Console.WriteLine(y = 1);
                }
            }
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int h = int.Parse(txtC.Text);
            Task answer = new Task(a, b, h);//Объявление объекта метода и ввод нужных данных
            answer.Tasker();//Выполнение функции
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
