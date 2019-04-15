using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Operations
    {
        public static int FloatHere() // Ищет вхождение ',' в строку 
        {
            int increase = 1;
            int in_num1 = Arguments.number1.IndexOf(',');
            int in_num2 = Arguments.number2.IndexOf(','); ;
            if (in_num1 != -1)
            {
                in_num1 = Arguments.number1.Length - in_num1 - 1;
            }
            if (in_num2 != -1)
            {
                in_num2 = Arguments.number2.Length - in_num2 - 1;
            }
            if (in_num1 > in_num2)
            {
                for (int i = 1; i <= in_num1; i++)
                {
                    increase *= 10;
                }
            }
            if (in_num1 < in_num2)
            {
                for (int i = 1; i <= in_num2; i++)
                {
                    increase *= 10;
                }
            }
            return increase;
        }
        public static void DivisionNumbers()
        {
            int e = FloatHere();
            if (Arguments.number1 == "0")
            {
                Arguments.result = "0";
                return;
            }
            Arguments.num1 = Convert.ToDouble(Arguments.number1);
            Arguments.num2 = Convert.ToDouble(Arguments.number2);
            Arguments.num1 = Arguments.num1 * e;
            Arguments.num2 = Arguments.num2 * e;
            Arguments.number1 = Convert.ToString(Arguments.num1);
            Arguments.number2 = Convert.ToString(Arguments.num2);
            bool stop = false;  // Остановка цикла
            bool put_comma = false; //Переменная, которая определяет наличие запятой
            int length_take = Arguments.number2.Length;
            int divider = Convert.ToInt32(Arguments.number2); //Делитель
            Arguments.ostatok = "0";
            bool start = true;
            while (!stop)
            {
                int length_num1 = Convert.ToInt32(Arguments.number1.Length);
                int i = 0;
                int num_dividend = Convert.ToInt32(Arguments.ostatok);
                while (num_dividend < divider)
                {
                    if (start)
                    {
                        if (Arguments.number1 == "")
                        {
                            if (!put_comma)
                            {
                                Arguments.result = Arguments.result + "0,";
                                Arguments.number1 = Arguments.number1 + '0';
                                put_comma = true;
                            }
                            else
                            {
                                Arguments.result = Arguments.result + '0';
                                Arguments.number1 = Arguments.number1 + '0';
                            }
                        }
                        Arguments.ostatok = Arguments.ostatok + Arguments.number1[0];
                        Arguments.number1 = Arguments.number1.Remove(0, 1);
                        num_dividend = Convert.ToInt32(Arguments.ostatok);
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (Arguments.number1 == "")
                            {
                                if (!put_comma)
                                {
                                    Arguments.result = Arguments.result + ',';
                                    Arguments.number1 = Arguments.number1 + '0';
                                    put_comma = true;
                                }
                                else
                                {
                                    Arguments.number1 = Arguments.number1 + '0';
                                }
                            }
                            Arguments.ostatok = Arguments.ostatok + Arguments.number1[0];
                            Arguments.number1 = Arguments.number1.Remove(0, 1); //Т.к. забрали элемент в деление, удаляем его
                            num_dividend = Convert.ToInt32(Arguments.ostatok);
                        }
                        else
                        {
                            Arguments.result = Arguments.result + '0'; // Элементов было взято больше чем 1, поэтому в результат добавляем 0
                            if (Arguments.number1 == "")
                            {
                                if (!put_comma)
                                {
                                    Arguments.result = Arguments.result + ',';
                                    Arguments.number1 = Arguments.number1 + '0';
                                    put_comma = true;
                                }
                                else
                                {
                                    Arguments.number1 = Arguments.number1 + '0';
                                }
                            }
                            Arguments.ostatok = Arguments.ostatok + Arguments.number1[0];
                            Arguments.number1 = Arguments.number1.Remove(0, 1);
                            num_dividend = Convert.ToInt32(Arguments.ostatok);
                        }
                        i++;
                    }
                }
                num_dividend = Convert.ToInt32(Arguments.ostatok);
                int c = num_dividend / divider;
                Arguments.result = Arguments.result + Convert.ToString(c);
                int ost = num_dividend - c * divider;
                Arguments.ostatok = Convert.ToString(ost);
                start = false;
                int stop_point = Arguments.result.IndexOf(',');
                if (stop_point != -1)
                {
                    if (Arguments.result.Length - stop_point > 12)
                    {
                        stop = true;
                    }
                }
            } //Конец деления
            bool clear = true;
            while (clear) //Очистка лишних 0
            {
                int last_symbol = Arguments.result.Length - 1;
                if ((Arguments.result[last_symbol] == '0')||(Arguments.result[last_symbol] == ','))
                {
                    Arguments.result = Arguments.result.Remove(last_symbol, 1);
                    if (Arguments.result[last_symbol] == ',')
                    {
                        clear = false;
                    }
                }
                else
                {
                    clear = false;
                }
            }
        }
    }
}