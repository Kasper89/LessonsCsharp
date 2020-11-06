using System;
using System.Collections.Generic;

namespace Lesson11
{
    class Program
    {
        //Урок 12. Generic.

        /*
         * Домашнее задание. 
         * В вашей предметной области определить клас и несколько наследников.         
         * Создать класс который будет принимать в качестве универсального типа базовый класс.
         * Поэкспериментировать с универсальными типами.
        */
        static void Main(string[] args)
        {
            var eating= new Eating<Product<int, decimal>>();
            var p = new Product<int,decimal>("Яблоко",100,100);
            var pp = new Product<decimal,int>("Яблоко", 10.1M, 1100);

            var lict = new List<int>();
            var map= new Dictionary<int,string>();
            map.Add(5,"Пять");
        }
    }
}
