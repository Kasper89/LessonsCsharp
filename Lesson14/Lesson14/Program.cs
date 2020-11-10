using System;
namespace Lesson14
{
    public delegate void MyDelegate();
    class Program
    {
        //Урок 15. Делегаты и события.

        /*
         *Домашнее задание. 
         * 
         * 
        */

        public delegate int ValueDelegate(int i);

        //public static Action ActionDelegate;

        //public static bool Predicate<T>(T value);

        //public static int Func(string value);
        public event MyDelegate Event;
        public event Action EventAction;

        static void Main(string[] args)
        {
            #region Delegate
            MyDelegate myDeligate = Method1;
            myDeligate += Method4;
            myDeligate();


            MyDelegate myDelegate2 = new MyDelegate(Method4);
            myDelegate2 += Method4;
            myDelegate2 -= Method4;
            myDelegate2.Invoke();

            MyDelegate myDelegate3 = myDeligate + myDelegate2;
            myDelegate3.Invoke();

            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;

            valueDelegate((new Random()).Next(10,50));//Одно значение от последнего делегата.

            //ActionDelegate = Method1;
            Action action = Method1;
            action();
            Action<int> action2 = Method3;
            action2((new Random()).Next(10,50));

            Predicate<int> predicate;

            Func<int, string> func;//Последний тип возвращаемого значения.
            Func<int, int> func2=MethodValue;
            func2(7);

            if (func2!=null)
            {
                func2(7);
            }

            //func2?.invoke(7);//не поддерживает 2013 студия.
            #endregion

            #region Event            

            Person person = new Person();
            person.Name = "Вася";
            person.GoToSleep += person_GoToSleep;
            person.DoWork += person_DoWork;
            person.TakeTime(DateTime.Parse("10.11.2020 21:31:15"));
            person.TakeTime(DateTime.Parse("10.11.2020 4:31:15"));

            var sum = Sum(5, 5, Calc1);
            var sum2 = Sum(5, 5, Calc2);

            Console.WriteLine(Sum(5, 5, Calc1));
            Console.WriteLine(Sum(5, 5, Calc2));

            #endregion



            Console.ReadLine();
        }

        static void person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine(((Person)sender).Name + " работает работу.");
            }
        }

        static void person_GoToSleep()
        {
            Console.WriteLine("Человек пошел спать");            
        }

        private static int Sum(int a, int b, Func<int,int, int> calc)
        {
            return calc(a,b);
        }

        private static int Calc1(int i, int j)
        {
            return i + j;
        }

        private static int Calc2(int i, int j)
        {
            return i * j;
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        public static void Method3(int i)
        {
            Console.WriteLine(i);
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
