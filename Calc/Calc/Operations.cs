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
            if (in_num1 >= in_num2)
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
        public static void SubtructionNumbers()
        {

        }

        public static void SummaryNumbers()
        {
            int e = FloatHere();
            Arguments.num1 = Convert.ToDouble(Arguments.number1);
            Arguments.num2 = Convert.ToDouble(Arguments.number2);
            Arguments.num1 = Arguments.num1 * e;
            Arguments.num2 = Arguments.num2 * e;
            Arguments.number1 = Convert.ToString(Arguments.num1);
            Arguments.number2 = Convert.ToString(Arguments.num2);
            int last_num1 = Arguments.number1.Length - 1;
            int index_num2 = Arguments.number2.Length - 1;
            while (last_num1 < index_num2)
            {
                Arguments.number1 = Arguments.number1.Insert(0, "0");
                last_num1++;
            }
            while (last_num1 > index_num2)
            {
                Arguments.number2 = Arguments.number2.Insert(0, "0");
                index_num2++;
            }
            int summ_add = 0;
            string for_result = "";
            for (int j = last_num1; j >= 0; j--)
            {
                string add1 = Arguments.number1.Substring(j, 1);
                string add2 = Arguments.number2.Substring(j, 1);
                int add_num1 = Convert.ToInt32(add1);
                int add_num2 = Convert.ToInt32(add2);
                string sum = "";
                int summ = add_num1 + add_num2 + summ_add;
                sum = Convert.ToString(summ);
                if ((sum.Length > 1) && (j != 0))
                {
                    summ_add = Convert.ToInt32(sum.Substring(0, 1));
                    sum = sum.Remove(0, 1);
                    for_result = for_result.Insert(0, sum);
                }
                else
                {
                    summ_add = 0;
                    for_result = for_result.Insert(0, sum);
                }
            }
            double summary = Convert.ToDouble(for_result);
            summary = summary / e;
            Arguments.result = Convert.ToString(summary);
        }

        public static void MultiplyNumbers()
        {
            if ((Arguments.number1 == "0") || (Arguments.number2 == "0"))
            {
                Arguments.result = "0";
                return;
            }
            int e = FloatHere();
            Arguments.num1 = Convert.ToDouble(Arguments.number1);
            Arguments.num2 = Convert.ToDouble(Arguments.number2);
            Arguments.num1 = Arguments.num1 * e;
            Arguments.num2 = Arguments.num2 * e;
            Arguments.number1 = Convert.ToString(Arguments.num1);
            Arguments.number2 = Convert.ToString(Arguments.num2);
            int last_num1 = Arguments.number1.Length - 1;
            int index_num2 = Arguments.number2.Length - 1;
            if (last_num1 > index_num2)
            {
                string change = Arguments.number1;
                Arguments.number1 = Arguments.number2;
                Arguments.number2 = change;
                last_num1 = Arguments.number1.Length - 1;
                index_num2 = Arguments.number2.Length - 1;
            }
            int i = 1;
            while (index_num2 >= 0)
            {
                string value_number2 = Arguments.number2.Substring(index_num2, 1);
                int value = Convert.ToInt32(value_number2);
                int add = 0;
                string prom_arguments = "";
                for (int k = last_num1; k>=0; k--) // Проходим по всему первому числу
                {
                    string k_number1 = Arguments.number1.Substring(k, 1);
                    int k_num1 = Convert.ToInt32(k_number1);
                    int c = k_num1 * value + add;
                    string multiply_num = Convert.ToString(c);
                    if((multiply_num.Length > 1)&&(k != 0))
                    {
                        add = Convert.ToInt32(multiply_num.Substring(0, 1));
                        multiply_num = multiply_num.Remove(0, 1);
                        prom_arguments = prom_arguments.Insert(0, multiply_num);
                    }
                    else
                    {
                        add = 0;
                        prom_arguments = prom_arguments.Insert(0, multiply_num);
                    }
                }
                for (int j = 1; j < i; j++)
                {
                    prom_arguments = prom_arguments + '0';
                }
                if (i == 1)
                {
                    Arguments.result = prom_arguments;
                }
                else
                {
                    while (Arguments.result.Length < prom_arguments.Length)
                    {
                        Arguments.result = Arguments.result.Insert(0, "0");
                    }
                    int summ_add = 0;
                    string for_result = "";
                    for (int j = prom_arguments.Length - 1; j >= 0 ; j--)
                    {
                        string add1 = prom_arguments.Substring(j, 1);
                        string add2 = Arguments.result.Substring(j, 1);
                        int add_num1 = Convert.ToInt32(add1);
                        int add_num2 = Convert.ToInt32(add2);
                        string sum = "";
                        int summ = add_num1 + add_num2 + summ_add;
                        sum = Convert.ToString(summ);
                        if ((sum.Length > 1)&&(j != 0))
                        {
                            summ_add = Convert.ToInt32(sum.Substring(0, 1));
                            sum = sum.Remove(0, 1);
                            for_result = for_result.Insert(0, sum);
                        }
                        else
                        {
                            summ_add = 0;
                            for_result = for_result.Insert(0, sum);
                        }
                    }
                    Arguments.result = for_result;
                }
                i++;
                index_num2--;
            }
            double summary = Convert.ToDouble(Arguments.result);
            summary = summary / e / e;
            Arguments.result = Convert.ToString(summary);
        }

        public static void DivisionNumbers()
        {
            if (Arguments.number1 == "0")
            {
                Arguments.result = "0";
                return;
            }
            int e = FloatHere();
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
                int length_num1 = Arguments.number1.Length;
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