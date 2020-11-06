using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        //Урок 14.Exception.
        /*
         * Домашнее задание. 
         * 
         * Создать свой класс исключения.
         * Сгенерировать свое исключение.
         * Добавить проверку в работе с классами try/catch/catch/catch/catch/finally.
         * Отловить свое и другие исключения.
        */
        static void Main(string[] args)
        {
            while(true)
            {
                var input = Console.ReadLine();
                int result;
                if(int.TryParse(input, out result))
                {
                    Console.WriteLine("Ваше число: "+result);
                    break;
                }
                else 
                {
                    Console.WriteLine("Некорректное чисо! Введите целое число.");
                }
            }

            try
            {
                throw new MyOneException();
                throw new MyOneException("Пи-пи-пи-пип");
                throw new ArithmeticException();

                var i = 5;
                var p = 0;
                var j = i / p;
                Console.WriteLine(j);

                int a = 2000000;
                int b = 222222222;
                int c = checked(a * b);
                Console.WriteLine(c);
            }
            catch (MyOneException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex) //when (i==5) //Нет поддержки дополнительных условий исключения в студии 2013.
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Какое-то исключение");
                //throw; //Проброс исключения выше.
            }
            finally
            {
                Console.WriteLine("Работа завершена.");
                Console.ReadLine();
            }
        }
    }
}
