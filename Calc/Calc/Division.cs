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
            bool stop = false;  // Остановка цикла
            bool put_comma = false; //Переменная, которая определяет наличие запятой
            int length_num2 = Arguments.number2.Length;
            int divider = Convert.ToInt32(Arguments.number2); //Записываем делитель
            // Проверка
            while (!stop)
            {
                int length_num1 = Arguments.number1.Length;
                int c = 0;
                if (length_num1 >= length_num2)
                {
                    int length_num = length_num2;
                    string str_argument1 = Arguments.number1.Substring(0, length_num); //Обрезаем строку под размер делителя
                    int dividend = Convert.ToInt32(str_argument1);                     
                    if (dividend >= divider) //Если делимое больше или равно делителю
                    {
                        c = dividend / divider;
                        Arguments.result = Arguments.result + Convert.ToString(c);
                        int ostatok = dividend - c * divider;
                        Arguments.number1 = Arguments.number1.Remove(0, length_num);
                        // if (ostatok != 0) //Если результат операции не равен 0, то обрезав строку добавим остаток
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
