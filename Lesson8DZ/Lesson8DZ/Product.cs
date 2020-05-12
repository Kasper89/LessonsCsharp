using System;

namespace Lesson8DZ
{
    class Product
    {
        string Name { get; set; }
        double Weight { get; set; }
        string Unit { get; set; }

        public Product(string name, double weight, string unit)
        {
            if (string.IsNullOrWhiteSpace(name)||string.IsNullOrWhiteSpace(unit))
            {
                throw new ArgumentNullException("Название продукта и единица измерения не должны быть пустыми!");
            }

            if (weight<0)
            {
                throw new ArgumentNullException("Вес не может быть меньше 0!");
            }

            Name = name;
            Weight = weight;
            Unit = unit;
        }
    }
}
