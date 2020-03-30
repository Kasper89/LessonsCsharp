using System;
using System.Runtime.InteropServices;

namespace Lesson3
{
    class Program
    {
        //Приведение и преобразование переменных
        static void Main(string[] args)
        {
            ////Не явное приведение типов
            //byte b = 42;//Возможные значения от 0 до 255
            //int i = b;//Возможные значения от -2 миллиардов до 2 миллиардов

            ////Явное приведение типов
            //int ii = 5;
            //int j = 2048;//-1=255,+1=1
            ////byte b = i;//Ошибка 
            //byte q = (byte)i;
            ////byte bb = j;//Тоже ошибка
            //byte bb = (byte)j;//Тоже ошибка


            ////string s = "2048";
            ////string s = "fsd";
            //string s = "1234";
            ////int jojo = (int)s;//Ошибка
            
            ////Явное преобразование переменных
            //int iii = Convert.ToInt32(s);//Ошибка string s = "fsd";
            //int iiii = int.Parse("42");
            ////int i = int.TryParse("42");


            //Не явное преобразование
            //int i = 1;
            //string s = "str " + i;

            bool b = true;
            //string s = b.ToString();
            string s = "true";//0 и 1 не преобразует
            b = Convert.ToBoolean(s);


            Console.WriteLine(s);
            //Console.ReadLine();

            if (int.TryParse("123", out int result))
            {
                Console.WriteLine(result);
            }

            if (int.TryParse(Console.ReadLine(), out int result2))
            {
                Console.WriteLine(result2);
            }
            //string s = "1";
            //int i = s;//Ошибка
            //int j = 5;
            //double d = j;//Нет ошибки 
            //int k = d;//Ошибка 

            #region Стили переменных
            //стили наименования переменных
            string UserName;
            int MaxSize;
            int x; //Такие переменные нельзя использовать!!!(итератор в цикле и то не всегда)
            string UpperCamelCase;//Верхняя верблюжья нотация (PascalCase)
            string lowerCamelCase;//Нижняя верблюжья нотация
            string snake_case;//Змеиная нотация
            string FAT_SNAKE_CASE;//Толстая змеиная нотация
            //string kebab-case;//Шашлычная нотация
            string sHungarianCase; //Венгерская нотация(s-тип переменной)
            #endregion
            Console.ReadLine();
        }
    }
}
