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

namespace WpfApp1
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
        public int Sum(int x1, int x2, int x3)
        {
            int sum = 0;//вводим переменную для суммы с начальным значением 0
            sum = sum + x1; //прибавляем первое слагаемое
            sum = sum + x2; //прибавляем второе слагаемое
            sum = sum + x3; //прибавляем третье слагаемое
            return sum;
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {

            int value1, value2, value3;
            value1 = int.Parse(Amount1.Text);
            value2 = int.Parse(Amount2.Text);
            value3 = int.Parse(Amount3.Text);
            int sum = Sum(value1, value2, value3);
            Answer.Text = sum.ToString();
        }

        int Max(int x1, int x2, int x3)
        {
            int max = int.MinValue; //вводим переменную для максимума с начальным значением MinValue
                if (x1 > max) max = x1; //максимум из одного значения
                if (x2 > max) max = x2; //максимум из двух значений
                if (x3 > max) max = x3; //максимум из трех значения
            return max; //возвращаем результат
        }
        void MaxAndName(int x1, int x2, int x3, string name1, string name2, string name3, out int max, out string name_max)
        {
            max = int.MinValue; //вводим переменную для максимума с начальным значением MinValue
            name_max = "";
            if (x1 > max){
                max = x1; name_max = name1; //максимум из одного значения и имя
            }
            if (x2 > max){
            max = x2; name_max = name2; //максимум из двух значений и имя
            }
            if (x3 > max){
                max = x3; name_max = name3; //максимум из трех значений и имя
            }
        }
        private void max_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, value3;
            value1 = int.Parse(Amount1.Text);
            value2 = int.Parse(Amount2.Text);
            value3 = int.Parse(Amount3.Text);
            int max = Max(value1, value2, value3);
            Answer.Text = max.ToString();
        }

        private void maxname_Click(object sender, RoutedEventArgs e)
        {
            //входные данные. Ввод значений
            int value1, value2, value3;
            string name1, name2, name3;
            value1 = int.Parse(Amount1.Text);
            value2 = int.Parse(Amount2.Text);
            value3 = int.Parse(Amount3.Text);
            name1 = Name1.Text;
            name2 = Name2.Text;
            name3 = Name3.Text;
            //результаты
            int max_value;
            string max_name;
            //вычисления
            MaxAndName(value1, value2, value3,
            name1, name2, name3,
            out max_value, out max_name);
            //вывод результатов
            Answer.Text = max_name +  max_value + " Больше всех!" ;
        }

        int Min(int x1, int x2, int x3)
        {
            int max = int.MaxValue; //вводим переменную для минимума с начальным значением MinValue
            if (x1 < max) max = x1; //минимум из одного значения
            if (x2 < max) max = x2; //минимум из двух значений
            if (x3 < max) max = x3; //минимум из трех значения
            return max; //возвращаем результат
        }

        void MinAndName(int x1, int x2, int x3, string name1, string name2, string name3, out int max, out string name_max)
        {
            max = int.MaxValue; //вводим переменную для минимума с начальным значением MinValue
            name_max = "";
            if (x1 < max)
            {
                max = x1; name_max = name1; //минимум из одного значения и имя
            }
            if (x2 < max)
            {
                max = x2; name_max = name2; //минимум из двух значений и имя
            }
            if (x3 < max)
            {
                max = x3; name_max = name3; //минимум из трех значений и имя
            }
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, value3;
            value1 = int.Parse(Amount1.Text);
            value2 = int.Parse(Amount2.Text);
            value3 = int.Parse(Amount3.Text);
            int max = Min(value1, value2, value3);
            Answer.Text = max.ToString();
        }

        public int prod(int x1, int x2, int x3)
        {
            int sum = 1;//вводим переменную для суммы с начальным значением 0
            sum = sum * x1; //прибавляем первое слагаемое
            sum = sum * x2; //прибавляем второе слагаемое
            sum = sum * x3; //прибавляем третье слагаемое
            return sum;
        }

        private void pro_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, value3;
            value1 = int.Parse(Amount1.Text);
            value2 = int.Parse(Amount2.Text);
            value3 = int.Parse(Amount3.Text);
            int sum = prod(value1, value2, value3);
            Answer.Text = sum.ToString();
        }

        private void Answer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
