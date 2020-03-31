using System;
using System.Collections.Generic;

namespace Lesson4DZ
{
    class Program
    {
        enum Days
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
        static void Main(string[] args)
        {
            int[] days = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            List<string> ListDays = new List<string>
            {
            "День недели: ",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
            };
            Console.WriteLine(ListDays[0]+ListDays[(int)Days.Monday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Tuesday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Wednesday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Thursday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Friday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Saturday]);
            Console.WriteLine(ListDays[0] + ListDays[(int)Days.Sunday]);
            Console.WriteLine();
            Console.WriteLine(ListDays[0] + ListDays[days[0]]);
            Console.WriteLine(ListDays[0] + ListDays[days[1]]);
            Console.WriteLine(ListDays[0] + ListDays[days[2]]);
            Console.WriteLine(ListDays[0] + ListDays[days[3]]);
            Console.WriteLine(ListDays[0] + ListDays[days[4]]);
            Console.WriteLine(ListDays[0] + ListDays[days[5]]);
            Console.WriteLine(ListDays[0] + ListDays[days[6]]);
            Console.WriteLine();
            Console.WriteLine("Введите номер дня: ");
            if (int.TryParse(Console.ReadLine(), out int result)&&result<8)
            {
                Console.WriteLine(ListDays[result]);
            }
            else
            {
                Console.WriteLine("Введено не число или число более 7!");                
            }
            Console.ReadLine();
        }
    }
}
