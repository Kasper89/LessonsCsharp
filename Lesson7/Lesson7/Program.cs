using System;

namespace Lesson7
{
    #region модификаторы доступа

    //public - Открытый/публичный
    //internal - Открытый в пределах проекта
    //protected - Защищенный только для родственных связей
    //private - Закрытый только внутри класса

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //Int32 j = new Int32();

            Person person = new Person();
            person.FirstName = "Вадим";
            person.LastName = "Шванов";

            Person p2 = new Person();
            p2.FirstName = "Иван";
            p2.LastName = "Иванов";

            var d = new Doctor();
            d.FirstName = "Роман";
            d.Specialization = "333";

            Console.WriteLine(d.FirstName);
            Console.WriteLine(d.Specialization);

            Person p = d;//Отбрасываем все от доктора и оставляем только человека.

            Console.WriteLine(p.FirstName);

            Doctor dd = (Doctor)p;//Восстановление доктора.

            Console.WriteLine(dd.FirstName);
            Console.WriteLine(dd.Specialization);


            Console.ReadLine();
        }
    }
}
