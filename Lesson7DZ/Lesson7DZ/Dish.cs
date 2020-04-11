using System;
using System.Collections.Generic;

namespace Lesson7DZ
{
    public class Dish
    {
        public string NameDish;
        public string СookingDish;
        public TimeSpan CookingDish_Time;
        public List<Product> product= new List<Product>();
        public decimal CalorieDish;
        public List<Dish> Dishes = new List<Dish>();

    }
}
