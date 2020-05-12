using System;
using System.Runtime.InteropServices;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var secondName = Console.ReadLine();
            //Person p = new Person("Пупкин","Вася");
            Person p = new Person(secondName, name);
            Console.WriteLine(p.Name); 
            Console.WriteLine(p.SecondName);
            //Person p = new Person();
            //p.Name = "Вася";
            //p.SetName("Вася"); //Для методов доступа.
            //p.SetName(""); //Ошибка.
            //p.Name = "Вася";
            //p.SecondName = "Пупкин";
            //Console.WriteLine(p.GetName());
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.FullName);
            //Console.WriteLine(p.ShortName);
            Console.ReadLine();
        }
    }
}
