using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        /*
         *Домашнее задание.На 10 уроке. 
         * Определить и реализовать действия классов в рассматриваемой предметной области.
         * реализовать рекурсивное вычисление n-го числа Фибоначчи.
        */
        static void Main(string[] args)
        {            
            var i = PrintHelloo("Вадим",27);
            Console.WriteLine(i);
            var name = Console.ReadLine();
            var age = Convert.ToInt32(Console.ReadLine());
            PrintHelloo(name, age);
            var person1 = new Person("Попов","Антон");
            var perso2 = new Person("Петров","Петр");
            for (var i2 = 0; i2 < 10; i2++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);
                Console.WriteLine(perso2.Run());
            }

            Console.WriteLine(Factorial(5));

            Console.ReadLine();
        }

        /*
        модификатор_доступа тип_возвращаемого_значения(void-не возвращает значения) имя-метода (тип_аргумента имя_аргумента, ..., ...тип_аргументаN имя_аргументаN)        
        {
            тело_метода
            если указан тип возвращаемого значения кроме void то необходимо писать return
            return;
        }
        */

        public static int PrintHelloo(string name, int age)
        {
            Console.WriteLine("Привет, "+name+". Вам "+age+" лет.");
            return 2;
        }


        public static int Factorial(int value)
        {
            if (value<=1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
