using System;

namespace Lesson7DZ
{
    public class Product
    {
        public decimal CalorieProduct;
        public string UnitProduct;
        public decimal QuantityProduct;

        public decimal CalorieTo100()
        {
            return (QuantityProduct/100)*CalorieProduct;
        }
    }
}
