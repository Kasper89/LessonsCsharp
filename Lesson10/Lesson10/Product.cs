using System;

namespace Lesson10
{
    public abstract class Product
    {
        public string Name { get; set; }
        /// <summary>
        /// Калорийность на 100г продукта
        /// </summary>
        public int Calorie { get; set; }
        /// <summary>
        /// Объем в граммах
        /// </summary>
        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return (Volume / 100.0) * Calorie;
            }
        }

        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Пустое имя!");
            }

            if (calorie < 0)
            {
                throw new ArgumentNullException("Калории не могут быть меньше 0.");
            }

            if (volume <= 0)
            {
                throw new ArgumentNullException("Объем не может быть меньше 0.");
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return Name + ". Калорийность: " + Calorie + ", Объем: " + Volume;
        }
    }
}
