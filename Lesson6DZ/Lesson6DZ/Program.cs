using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lesson6DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var count = 15;
            var temp = 0;
            var summ = 0;
            int difference;
            var product = 1;
            do
            {
                Console.WriteLine("Введите целое число: ");
                var item = Console.ReadLine();
                if(int.TryParse(item, out int result))
                {
                    list.Add(result);
                }
                else
                {
                    Console.WriteLine("Введено не целое число! Повторите ввод");
                }
            }
            while (list.Count<count);

            for(var i =0; i<list.Count;i++)
            {
                summ += list[i];
            }

            Console.WriteLine("Сумма элементов коллекции: "+summ);

            difference = list[0];
            temp = 1;
            while(temp <list.Count)
            {
                difference -= list[temp];
                temp++;
            }
            temp = 0;

            Console.WriteLine("Разность элементов коллекции: "+difference);            

            do
            {
                
                product *=  list[temp];
                temp++;
            }
            while (temp < count);

            Console.WriteLine("Произведение элементов коллекции: "+product);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
