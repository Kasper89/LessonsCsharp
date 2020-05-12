using System;
using System.Globalization;

namespace Lesson8
{
    public class Person
    {
        public Person(string secondName, string name) //Проверять входящие значения.
        {
            if (string.IsNullOrWhiteSpace(name)|| string.IsNullOrWhiteSpace(secondName))
            {
                throw new ArgumentNullException("Имя не может быть пустым!");
            }

            SecondName = secondName;
            Name = name;
        }
        //public string Name;
        //private string _name;
        //string _name;

        public string SecondName { get; set; }

        public string Name { get; set; }

        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }

        public string ShortName
        {
            get 
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";
            }
        }

        //public string SecondName {private get; protected set; }

        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("Имя не может быть пустым!");
        //        }

        //        _name = value;
        //    }
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException("Имя не может быть пустым!");
        //    }
        //    _name = name;
        //}
    }
}
