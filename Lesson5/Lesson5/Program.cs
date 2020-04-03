using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условные операторы
            //bool b = 3 < 5;//true; //false
            //<,<=,>,>=,==,!=
            //&&-и , || - или , !- не
            int input = int.Parse(Console.ReadLine());

            //var s = input == 10 ? "да" : "нет";

            Console.WriteLine(input == 10 ? "да" : "нет");

            if (input < 10 && input > 0)
            {
                //Console.WriteLine(true);
                //if (input>0)
                Console.WriteLine("Больше");
            }
            else
            {
                //Console.WriteLine(false);
                Console.WriteLine("Меньше");
            }

            switch(input)
            {
                case 1:
                    //действия
                    break;
                case 2:
                    //действия
                case 3:
                    //действия
                    break;
                default://не обязателен
                    //действия если не попадает ни в один case
                    break;
            }
            #endregion

            #region Безусловный оператор перехода (Так делать нельзя) (Не использовать)
            goto inte;
            inter:

        inte:
            Console.WriteLine("goto");
            goto inter;


            #endregion


            Console.ReadLine();
        }
    }
}
