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

namespace Calc
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

        public void CheckArg(string symbol) //Проверяет было ли введено первое число
        {
            string comparasion = Arg1.Content.ToString();
            if (comparasion == "") //Не введено, записываем его со знаком операции
            {
                NumberBox.Text = NumberBox.Text.TrimEnd(',');
                comparasion = NumberBox.Text;
                comparasion = comparasion + " " + symbol;
                Arg1.Content = comparasion;
                NumberBox.Text = "0";
            }
            if (comparasion != "") //Введено, просто меняем знак операции
            {
                comparasion = comparasion.Remove(comparasion.Length - 1);
                comparasion = comparasion + symbol;
                Arg1.Content = comparasion;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Записывает В NumberBox 1
        {
            if (NumberBox.Text.Length < 13) //Ограничивает кол-во записываемых символов
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1)) //Уберает первый символ, равный 0
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 1;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Записывает В NumberBox 2
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 2;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Записывает В NumberBox 3
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 3;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Записывает В NumberBox 4
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 4;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Записывает В NumberBox 5
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 5;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //Записывает В NumberBox 6
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 6;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //Записывает В NumberBox 7
        { 
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 7;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //Записывает В NumberBox 8
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 8;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) //Записывает В NumberBox 9
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 9;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //Записывает В NumberBox 0
        {
            if (NumberBox.Text.Length < 13)
            {
                if ((NumberBox.Text[0] == '0') && (NumberBox.Text.Length == 1))
                {
                    NumberBox.Clear();
                }
                NumberBox.Text = NumberBox.Text + 0;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //Записывает В NumberBox ','
        {
            int float_here = NumberBox.Text.IndexOf(',');
            if ((float_here == -1) && (NumberBox.Text.Length < 12))
            {
                NumberBox.Text = NumberBox.Text + ',';
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) //Операция сложения
        {
            CheckArg("+");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //Операция вычитания
        {
            CheckArg("-");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) //Операция умножения
        {
            CheckArg("*");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //Операция деления
        {
            CheckArg("/");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) //Очистка символа
        {
            if (NumberBox.Text.Length == 1)
            {
                NumberBox.Text = "0";
            }

            if (NumberBox.Text.Length > 1)
            {
                NumberBox.Text = NumberBox.Text.Remove(NumberBox.Text.Length - 1);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e) //Результат
        {
            string num1 = Arg1.Content.ToString();
            if (Arg1.Content.ToString() != "") //Если введено первое чиисло, то выполняем операцию
            {
                Arguments.number1 = num1;
                Arguments.number2 = NumberBox.Text.TrimEnd(',');
                Division.DivisionNumbers();
            }
        }
    }
}
