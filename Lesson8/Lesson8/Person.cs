using System;

namespace Lesson8
{
    public class Person
    {
        
        //public string Name; //Так делать не нужно. Для примера!
        /* //Так выглядит без синтаксического сахара.
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым!");
            }
            _name = name;
        }
         */
        public string SecondName { get; set; } //Авто-свойства.
        //public string SecondName { get; protected set; } //Авто-свойства. Можно задавать модификаторы доступа.
        public string Name { get; set; }

        public string  FullName 
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
                //return $"{SecondName} {Name.Substring(0, 1)}."; //Используя интерпаляцию строк.
                return SecondName + " " + Name.Substring(0, 1)+".";// В 2013 студии не поддерживается интерпаляция строк.
            }
        }
        public Person(string name,string secondName)
        {
            //Обязательно делать проверки.
            Name = name;
            SecondName = secondName;
        }
        public Person()
        {

        }
        /*
        private string _name;

        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя не может быть пустым!");
                }
                //_name = value+" Пупкин"; //Может изменятся во время присвоения.
                _name = value;
            }
        }
        */
    }
}
