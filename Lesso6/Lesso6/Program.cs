using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //break; - Завершение выполнения цикла

            /*continue; - Продолжить цикл не смотря на то что завершается текущая итерация.
            Все что после него в цикле выполнятся не будет.*/

            #region for
            //var list = new List<int>();
            //for (int i = 0; i < 10; i += 2)
            //{
            //    list.Add(i);
            //    //if (i==5)
            //    //{
            //    //    break;
            //    //}
            //}

            ////Бесконечный цикл
            ////for (;;)
            ////{

            ////}

            //for (var i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region while

            //var list = new List<string>();
            //while(list.Count<5)
            //{
            //    list.Add(Console.ReadLine());
            //}

            //var i = 0;
            //while(i<list.Count)
            //{
            //    Console.WriteLine(list[i]);
            //    i++;
            //}

            #endregion

            #region do

            //var list = new List<string>();

            //while (list.Count<5)
            //{
            //    list.Add(Console.ReadLine());
            //}

            //var i = 0;
            //do
            //{
            //    Console.WriteLine(list[i]);
            //    i++;
            //}
            //while (i < list.Count);

            #endregion

            #region foreach

            var list = new List<string>();

            var rnd = new Random();//Рандомайзей

            for(var i=0; i <10; i++)
            {
                list.Add(rnd.Next(0,100).ToString());
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Вложенные циклы

            //int[,] array = new int[10, 10];

            //for(var i=0;i<10;i++)
            //{
            //    for(var j=0;j<10;j++)
            //    {
            //        array[i, j] = 8;
            //    }
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
