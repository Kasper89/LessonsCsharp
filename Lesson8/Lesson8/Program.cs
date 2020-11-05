using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Домашнее задание 
             * 
             * Создать классы со свойствами из выбранной предметной области.
             * 
             */
            Person p = new Person();
            //p.Name = "Вася";//не верно!
            //p.SetName("Вася");

            //Console.WriteLine(p.GetName());
            Person p1 = new Person("Петя", "Пупкин");
            p.Name = "Вася";
            p.SecondName = "Пупкин";            
            Console.WriteLine(p.FullName);
            Console.WriteLine(p.ShortName);
            Console.WriteLine(p1.FullName);
            Console.WriteLine(p1.ShortName);
            Console.ReadLine();
        }
    }
}
