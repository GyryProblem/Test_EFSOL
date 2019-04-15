using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Division
    {
        public static int FloatHere()
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
            Arguments.operation = Arguments.number1.Remove(0, Arguments.number1.Length - 1);
            Arguments.number1 = Arguments.number1.Remove(Arguments.number1.Length - 2, 2);
            int e = FloatHere();
            Arguments.num1 = Convert.ToDouble(Arguments.number1);
            Arguments.num2 = Convert.ToDouble(Arguments.number2);
            Arguments.num1 = Arguments.num1 * e;
            Arguments.num2 = Arguments.num2 * e;
            Arguments.number1 = Convert.ToString(Arguments.num1);
            Arguments.number2 = Convert.ToString(Arguments.num2);
            Arguments.ostatok = "";
            bool stop = false;  // Остановка цикла
            bool put_comma = false; //Переменная, которая определяет наличие запятой
            int length_take = Arguments.number2.Length;
            int divider = Convert.ToInt32(Arguments.number2);
            //while (!stop)
            //{
            //    int length_num1 = Arguments.number1.Length;
            //    if (length_take <= length_num1 + Arguments.ostatok.Length)
            //    {
            //        int i = 0; // Кол-во символов, которые будем рать для деления
            //        while (Arguments.ostatok.Length != length_take)
            //        {
            //            if (Arguments.number1.Length + Arguments.ostatok.Length < length_take)
            //            {
            //                Arguments.number1 = Arguments.number1 + '0';
            //                if (Arguments.result == null)
            //                {
            //                    Arguments.result = "0,";
            //                    put_comma = true;
            //                }
            //                else
            //                {
            //                    if (!put_comma)
            //                    {
            //                        Arguments.result = Arguments.result + ',';
            //                        put_comma = true;
            //                    }
            //                }
            //            }
            //            Arguments.ostatok = Arguments.ostatok + Arguments.number1[i];
            //            if (i > 0)
            //            {
            //                if (Arguments.result != null)
            //                {
            //                    Arguments.result = Arguments.result + '0';
            //                }
            //            }
            //            i++;
            //        }
            //        int dividend = Convert.ToInt32(Arguments.ostatok);
            //        if (dividend > divider)
            //        {
            //            int c = dividend / divider;
            //            Arguments.result = Arguments.result + Convert.ToString(c);
            //            int ost = dividend - divider * c;
            //            Arguments.ostatok = Convert.ToString(ost);
            //            Arguments.number1 = Arguments.number1.Remove(0, i);
            //        }
            //        else
            //        {
            //            if (i <= length_num1)
            //            {
            //                if (Arguments.result != null)
            //                {
            //                    Arguments.result = Arguments.result + '0';
            //                }
            //                Arguments.ostatok = Arguments.ostatok + Arguments.number1[i];
            //                dividend = Convert.ToInt32(Arguments.ostatok);
            //                int c = dividend / divider;
            //                Arguments.result = Arguments.result + Convert.ToString(c);
            //                int ost = dividend - divider * c;
            //                Arguments.ostatok = Convert.ToString(ost);
            //                Arguments.number1 = Arguments.number1.Remove(0, i + 1);
            //            }
            //            else
            //            {
            //                Arguments.number1 = Arguments.number1 + '0';
            //                if (!put_comma)
            //                {
            //                    Arguments.result = Arguments.result + ',';
            //                    put_comma = true;
            //                }
            //                if (Arguments.result != null)
            //                {
            //                    Arguments.result = Arguments.result + '0';
            //                }
            //                Arguments.ostatok = Arguments.ostatok + Arguments.number1[i];
            //                int c = dividend / divider;
            //                Arguments.result = Arguments.result + Convert.ToString(c);
            //                int ost = dividend - divider * c;
            //                Arguments.ostatok = Convert.ToString(ost);
            //                Arguments.number1 = Arguments.number1.Remove(0, i + 1);
            //            }
            //        }
            //    }
            //    else
            //    {
            //    }
            //}
            //bool start = true;
            //while (!stop)
            //{
            //    string ostatok = "";
            //    int length_num1 = Arguments.number1.Length;
            //    if (length_num1 >= length_take) //Если длина делимого больше
            //    {
            //        int i = 0;
            //        if (Arguments.ostatok_length >= length_take)
            //        {
            //            while (i != Arguments.ostatok_length + 1)
            //            {
            //                ostatok = ostatok + Arguments.number1[i];
            //                i++;
            //            }
            //        }
            //        else
            //        {
            //            while (i != length_take)
            //            {
            //                ostatok = ostatok + Arguments.number1[i];
            //                i++;
            //            }
            //        }
            //        if (!start)
            //        {
            //            if (Arguments.ostatok_length + 1 < ostatok.Length)
            //            {
            //                int add = ostatok.Length - 1 - Arguments.ostatok_length;
            //                for (int y = 1; y <= add; y++)
            //                {
            //                    Arguments.result = Arguments.result + '0';
            //                }

            //            }
            //        }
            //        //if (Arguments.ostatok_length + 1 < ostatok.Length)
            //        //{
            //        //    int add = ostatok.Length - 1 - Arguments.ostatok_length;
            //        //    if (!start)
            //        //    {
            //        //        for (int y = 1; y<=add; y++)
            //        //        {
            //        //            Arguments.result = Arguments.result + '0';
            //        //        }
            //        //    }
            //        //}
            //        int dividend = Convert.ToInt32(ostatok);
            //        if (dividend >= divider)
            //        {
            //            int c = dividend / divider;
            //            Arguments.result = Arguments.result + Convert.ToString(c);
            //            int ost = dividend - c * divider;
            //            ostatok = Convert.ToString(ost);
            //            Arguments.ostatok_length = Convert.ToInt32(ostatok.Length);
            //            Arguments.number1 = Arguments.number1.Remove(0, i);
            //            Arguments.number1 = Arguments.number1.Insert(0, ostatok);
            //            if (put_comma)
            //            {
            //                Arguments.number1 = Arguments.number1 + '0';
            //            }
            //        }
            //        else
            //        {
            //            if (i <= length_num1)
            //            {
            //                if (put_comma)
            //                {
            //                    Arguments.number1 = Arguments.number1 + '0';
            //                }
            //                if (!start)
            //                {
            //                    Arguments.result = Arguments.result + '0';
            //                }
            //                ostatok = ostatok + Arguments.number1[i];
            //                dividend = Convert.ToInt32(ostatok);
            //                int c = dividend / divider;
            //                Arguments.result = Arguments.result + Convert.ToString(c);
            //                int ost = dividend - c * divider;
            //                ostatok = Convert.ToString(ost);
            //                Arguments.ostatok_length = Convert.ToInt32(ostatok.Length);
            //                Arguments.number1 = Arguments.number1.Remove(0, i+1);
            //                Arguments.number1 = Arguments.number1.Insert(0, ostatok);
            //            }
            //            else
            //            {
            //                Arguments.number1 = Arguments.number1 + '0';
            //                if (!put_comma)
            //                {
            //                    Arguments.result = Arguments.result + ',';
            //                    put_comma = true;
            //                }
            //                else
            //                {
            //                    Arguments.result = Arguments.result + "0";
            //                }
            //            }
            //        }
            //    }
            //    else //Если длина делимого меньше
            //    {
            //        if (!put_comma)
            //        {
            //            if (Arguments.result == null)
            //            {
            //                Arguments.result = Arguments.result + "0";
            //            }
            //            Arguments.result = Arguments.result + ",";
            //            put_comma = true;
            //        }
            //        else
            //        {
            //        }
            //        Arguments.number1 = Arguments.number1 + "0";
            //        Arguments.ostatok_length = Convert.ToInt32(Arguments.number1.Length);
            //    }
            //    start = false;
            //}
            while (!stop)
            {
                int length_num1 = Arguments.number1.Length; //
                int c = 0;
                if (length_num1 >= length_take)
                {
                    int length_num = length_take; //
                    string str_argument1 = Arguments.number1.Substring(0, length_num); //Обрезаем строку под размер делителя
                    int dividend = Convert.ToInt32(str_argument1);
                    if (dividend >= divider) //Если делимое больше или равно делителю
                    {
                        c = dividend / divider;
                        Arguments.result = Arguments.result + Convert.ToString(c);
                        int ostatok = dividend - c * divider;
                        Arguments.number1 = Arguments.number1.Remove(0, length_num);
                        Arguments.number1 = Arguments.number1.Insert(0, Convert.ToString(ostatok));
                        if (put_comma)
                        {
                            Arguments.number1 = Arguments.number1 + "0";
                        }
                    }
                    else  //Если делимое меньше делителя
                    {
                        length_num = length_num + 1;
                        if (length_num <= length_num1) //Забираем из строки еще одно число
                        {
                            str_argument1 = Arguments.number1.Substring(0, length_num);
                            dividend = Convert.ToInt32(str_argument1);
                            c = dividend / divider;
                            Arguments.result = Arguments.result + Convert.ToString(c);
                            int ostatok = dividend - c * divider;
                            Arguments.number1 = Arguments.number1.Remove(0, length_num);
                            Arguments.number1 = Arguments.number1.Insert(0, Convert.ToString(ostatok));
                            if (put_comma)
                            {
                                Arguments.number1 = Arguments.number1 + "0";
                            }
                        }
                        else //Добавляем еще 0 
                        {
                            Arguments.number1 = Arguments.number1 + "0";
                            if (!put_comma)
                            {
                                Arguments.result = Arguments.result + ',';
                                put_comma = true;
                            }
                            else
                            {
                                Arguments.result = Arguments.result + "0";
                            }
                        }
                    }
                }
                else
                {
                    if (!put_comma)
                    {
                        if (Arguments.result == null)
                        {
                            Arguments.result = Arguments.result + "0";
                        }
                        Arguments.result = Arguments.result + ",";
                        put_comma = true;
                    }
                    else
                    {
                        Arguments.result = Arguments.result + "0";
                    }
                    Arguments.number1 = Arguments.number1 + "0";
                }
                if (Arguments.number1 == "00")
                {
                    break;
                }
            }
        }
    }
}
/* Новый алгоритм для деления: в самом начале цикла забираем длину числа такую, чтобы оно делилось нацело,
 * если число меньшей длины чем сам делитель и первая операция