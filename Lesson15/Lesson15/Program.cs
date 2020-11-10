using System;
using System.IO;
using System.Text;

namespace Lesson15
{
    //Урок 16. Потоки и файлы.

    /*
     *Домашнее задание. 
     * 
     * Создать приложение, которое запрашивает данные от пользователя.
     * Запысывает введенные данные в файл.
     * По команде читает данные из файла.
    */

    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.ASCII;//Перекодировка консоли.

            //Открыть. Создать поток.
            //Прочитать/Записать.
            //Закрыть. Или данные могут потеряться.

            using (var sw= new StreamWriter("test.txt"))//Позволяет создать объект для использования только внутри. После выполнения объект будет уничтожен.
            {
                sw.Write("Hello, World");
                sw.WriteLine("Hello, User");
            }

            using (var sw = new StreamWriter("test2.txt",true))//Дописывание данных.
            {
                sw.Write("Hello, World");
                sw.WriteLine("Hello, User");
            }

            using (var sw = new StreamWriter("test3.txt", true, Encoding.UTF8))//Кодировка.
            {
                sw.Write("Hello, World");
                sw.WriteLine("Hello, User");
            }

            using (var sw = new StreamWriter("test4.txt", false, Encoding.UTF8))//Кодировка.
            {
                sw.WriteLine("Hello, World");
                sw.WriteLine("Hello, User");
                sw.WriteLine("Привет");
            }

            using(var sr=new StreamReader("test4.txt",Encoding.UTF8))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            using (var sr = new StreamReader("test4.txt", Encoding.UTF8))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine()+" конец строки.");
                }

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
