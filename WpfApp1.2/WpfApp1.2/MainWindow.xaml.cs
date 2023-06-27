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

namespace WpfApp1._2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int value1 = int.Parse(speed1.Text);
            int value2 = int.Parse(speed2.Text);
            int value3 = int.Parse(speed3.Text);
            int value4 = int.Parse(speed12.Text);
            int value5 = int.Parse(speed22.Text);
            int value6 = int.Parse(speed32.Text);
            int value7 = int.Parse(speed13.Text);
            int value8 = int.Parse(speed23.Text);
            int value9 = int.Parse(speed33.Text);
            int avg1 = (value1 + value4 + value7) / 3;
            int avg2 = (value2 + value5 + value8) / 3;
            int avg3 = (value3 + value6 + value9) / 3;
            speed14.Text = avg1.ToString();
            speed24.Text = avg2.ToString();
            speed34.Text = avg3.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float min = float.MaxValue; //вводим переменную для максимума с начальным значением MinValue
            int value1 = int.Parse(speed1.Text);
            int value2 = int.Parse(speed2.Text);
            int value3 = int.Parse(speed3.Text);
            int value4 = int.Parse(speed12.Text);
            int value5 = int.Parse(speed22.Text);
            int value6 = int.Parse(speed32.Text);
            int value7 = int.Parse(speed13.Text);
            int value8 = int.Parse(speed23.Text);
            int value9 = int.Parse(speed33.Text);
            int avg1 = (value1 + value4 + value7) / 3;
            int avg2 = (value2 + value5 + value8) / 3;
            int avg3 = (value3 + value6 + value9) / 3;
            if (avg1 < min) min = avg1; //максимум из одного значения
            if (avg2 < min) min = avg2; //максимум из одного значения
            if (avg3 < min) min = avg3; //максимум из одного значения
            if (min == avg1){
                champ.Text = "Жора";
            }
            if (min == avg2)
            {
                champ.Text = "Алексей";
            }
            if (min == avg3)
            {
                champ.Text = "Михаил";
            }

        }
            }
        }

