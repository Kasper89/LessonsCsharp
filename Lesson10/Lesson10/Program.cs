using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        //Урок 11.

        /*
         * Домашнее задание.
         * Реализовать операции +,-,>,<,>=,<=,==,!= для класса из предметной области. 
         */
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 90, 110);
            var summApple = Apple.Add(apple, apple2);
            var summApple2 = apple + apple2;
            var summApple3 = apple + 100;
            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(summApple);
            Console.WriteLine(summApple2);
            Console.WriteLine(summApple3);
            Console.WriteLine(apple==apple2);
            Console.WriteLine(summApple==summApple2);

            Console.ReadLine();
        }
    }
}
