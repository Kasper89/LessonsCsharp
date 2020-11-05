using System;

namespace Lesson9
{
    public class Person
    {
        public string  SecondName { get; set; }
        public string  Name { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;
            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();
            X += rnd.Next(-2,2);
            Y += rnd.Next(-2,2);

            return Name + "("+X+","+Y+")";
        }

        /// <summary>
        /// Перегрузка метода Run().
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string Run(int x,int y)
        {
            X += x;
            Y += y;
            return Name + "(" + X + "," + Y + ")";
        }
    }
}
