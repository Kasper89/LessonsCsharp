using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        //Урок 13.
        /*
         * Домашнее задание.
         *  Определить интерфейс содержащий методы и свойства.
         *  Определить интерфейс наследник от первого интерфейса(еще методы).
         *  Реализовать второй интерфейс.
        */
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200));
            }

            var cyborg = new Cyborg();
            Console.WriteLine(((ICar)cyborg).Move(100));
            Console.WriteLine(((IPerson)cyborg).Move(100));

            Console.ReadLine();
        }
    }
}
