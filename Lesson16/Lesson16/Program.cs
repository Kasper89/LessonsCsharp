using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson16
{
    class Program
    {
        //Урок 17. Асинхронность и много поточность.

        /*
         *Домашнее задание. 
         * 
         * 1.
         * В своей предметной области создать метод со сложным вычислением.
         * Создать для этого метода обертку в виде async-метода.
         * Переписать с вой код в асинхронном варианте.
         * 
         * 2.
         * Создать в ручную поток.
         * Сделать для него повышенные приоритет.
         * Запустить выполнение и попробовать завершить приложение.
         * 
         * Использовать Lock.
        */

        public static object locker = new object();
        public static int i1 = 100;

        #region DeadLock
        //static void M1()
        //{
        //    for(int i= 0; i<=i1;i++)
        //    {

        //    }
        //}

        //static void M2()
        //{
        //    for(int i= 0; i>=i1;i--)
        //    {

        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine(args);//Параметры которые были введены при вызове exe.
            #region Потоки
            //Thread thread = new Thread(new ThreadStart (DoWork));
            //thread.Start();


            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            //thread2.Start(int.MaxValue);




            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;

            //    if (i % 10000 == 0)
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
            #endregion

            #region Асинхронность
            Console.WriteLine("Begin Main");

            DoWorkAsync(100);

            Console.WriteLine("Continue Main");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main");
            }
            Console.WriteLine("End Main");
            #endregion




            //var result = SaveFile("text.txt");
            var result = SaveFileAsync("text.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result);


            Console.ReadLine();
        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task<bool>.Run(()=>SaveFile(path));
            return result;
        }
        

        static bool SaveFile(string path)
        {
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next();
                }

                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.WriteLine(text);
                }
                return true;
            }
        }

        static async Task DoWorkAsync(int max)
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork(max));//Ждать конца выполнения.
            Console.WriteLine("End Async");
        }

        static void DoWork(int max)
        {

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("DoWork");
            }
        }

        static void DoWork2(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                Console.WriteLine("DoWork2");
            }
        }
    }
}
