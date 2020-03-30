using System;
using System.Runtime.InteropServices;

namespace Lesson2DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine(i);
            i = 6;
            Console.WriteLine(i);
            var v = -5;
            Console.WriteLine(v);
            double dobl = 5.1;
            double doble = 7.4;
            Console.WriteLine(dobl);
            Console.WriteLine(doble);
            Console.WriteLine("Сумма d+j: "+ (dobl + doble));
            char c = '=';
            char ca = 'f';
            Console.WriteLine(c);
            Console.WriteLine(ca);
            Console.WriteLine("Сумма c+ca: "+c+ca);
            bool b = true;
            bool bb = false;
            Console.WriteLine(b);
            Console.WriteLine(bb);
            string s = "bsfljbfsj jhdgsjh\r\n dsg";
            Console.WriteLine(s);
            decimal d = 0.5M;
            Console.WriteLine(d);
            float f = 0.7F;
            Console.WriteLine(f);
            dynamic j = 5;
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
