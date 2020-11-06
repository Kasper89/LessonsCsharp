using System;

namespace Lesson13
{
    //Можно унаследоваться от любого наследника Exception.
    class MyOneException : Exception
    {
        public MyOneException():base("Это мое исключение!")
        {         
        }

        public MyOneException(string message):base(message) 
        {            
        }
    }
}
