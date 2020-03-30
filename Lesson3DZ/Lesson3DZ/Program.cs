using System;

namespace Lesson3DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=102;
            Console.WriteLine(i);
            byte b=100;
            Console.WriteLine(b);
            bool bol=true;
            Console.WriteLine(bol);
            double dou=7.58;
            Console.WriteLine(dou);
            decimal dec=9.15M;
            Console.WriteLine(dec);
            float f = 15.75F;
            Console.WriteLine(f);
            string s="15";
            Console.WriteLine(s);
            i = b;
            Console.WriteLine(i);
            b = (byte)i;
            Console.WriteLine(b);
            i = Convert.ToInt32(bol);
            Console.WriteLine(i);
            dou = i;
            Console.WriteLine(dou);
            i = (int)dou;
            Console.WriteLine(i);
            dou = b;
            Console.WriteLine(dou);
            b = (byte)dou;
            Console.WriteLine(b);
            dec = (decimal)dou;
            Console.WriteLine(dec);
            dou = (double)dec;
            Console.WriteLine(dou);
            dec = i;
            Console.WriteLine(dec);
            i = (int)dec;
            Console.WriteLine(i);
            dec = b;
            Console.WriteLine(dec);
            b = (byte)dec;
            Console.WriteLine(b);
            f = i;
            Console.WriteLine(f);
            i = (int)f;
            Console.WriteLine(i);
            f = (float)dou;
            Console.WriteLine(f);
            dou = f;
            Console.WriteLine(dou);
            f = (float)dec;
            Console.WriteLine(f);
            dec = (decimal)f;
            Console.WriteLine(dec);
            f = b;
            Console.WriteLine(f);
            b = (byte)f;
            Console.WriteLine(b);
            i = Convert.ToInt32(s);
            Console.WriteLine(i);
            dou = Convert.ToDouble(s);
            Console.WriteLine(dou);
            dec = Convert.ToDecimal(s);
            Console.WriteLine(dec);
            f = (float)Convert.ToDecimal(s);
            Console.WriteLine(f);
            s = b.ToString();
            Console.WriteLine(s);
            b = Convert.ToByte(s);
            Console.WriteLine(b);

            Console.WriteLine("Все переменные: "+i+","+b + "," + bol + "," + dou + "," + dec + "," + f + "," + s);



            Console.ReadLine();
        }
    }
}
