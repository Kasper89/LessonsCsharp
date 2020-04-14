using System;

namespace Lesson7DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var potatoes = new potatoes();
            potatoes.Name = "Картофель";
            potatoes.UnitProduct = "кг.";
            potatoes.QuantityProduct = 1;
            potatoes.CalorieProduct = 430;

            var water = new water();
            water.Name = "Вода";
            water.UnitProduct = "мл.";
            water.QuantityProduct = 3000;
            water.CalorieProduct = 5;

            var carrot = new Carrot();
            carrot.Name = "Морковь";
            carrot.UnitProduct = "г.";
            carrot.QuantityProduct = 50;
            carrot.CalorieProduct = 40;

            var onion = new onion();
            onion.Name = "Лук";
            onion.UnitProduct = "г.";
            onion.QuantityProduct = 50;
            onion.CalorieProduct = 40;


            var oil = new Oil();
            oil.Name = "Масло";
            oil.UnitProduct = "мл.";
            oil.QuantityProduct = 50;
            oil.CalorieProduct = 40;

            var overcooking = new Dish();
            overcooking.NameDish = "Пережарка";
            overcooking.product.Add(carrot);
            overcooking.product.Add(onion);
            overcooking.product.Add(oil);
            overcooking.СookingDish = "Обжарить лук и морковь на растительном масле.";
            TimeSpan resultcook;
            if(TimeSpan.TryParse("0:15:0", out resultcook))
            {
                overcooking.CookingDish_Time = resultcook;
            }
            foreach(var item in overcooking.product)
            {
                overcooking.CalorieDish += item.CalorieTo100();
            }


            var sup = new Dish();
            sup.NameDish = "Суп";
            sup.product.Add(potatoes);
            sup.product.Add(water);
            sup.Dishes.Add(overcooking);
            sup.СookingDish = "За кипятить воду. Кинуть пережарку и картофель.";
            TimeSpan result;
            if(TimeSpan.TryParse("3:15:0", out result))
            {
                sup.CookingDish_Time = result;
            }
            Console.WriteLine(sup.NameDish);
            Console.WriteLine();
            Console.WriteLine("Состав:");
            var Qualiti = 0.0M;
            var Cal = 0.0M;
            foreach (var itemDish in sup.Dishes)
            {

                foreach (var itemProduct in itemDish.product)
                {
                    Qualiti += itemProduct.QuantityProduct;
                    Cal += itemProduct.CalorieTo100();
                }
                Console.WriteLine(itemDish.NameDish+" "+Qualiti+" г."+" Калорийность блюда: "+Cal + " ккал");
            }
            foreach(var item in sup.product)
            {
                string Name;

                switch(item.GetType().Name)
                {
                    case "Oil":
                        Oil oil1 = new Oil();
                        oil1 = (Oil)item;
                        Name = oil1.Name;
                        break;
                    case "potatoes":
                        potatoes potatoes1 = new potatoes();
                        potatoes1 = (potatoes)item;
                        Name = potatoes1.Name;
                        break;
                    case "water":
                        water water1 = new water();
                        water1 = (water)item;
                        Name = water1.Name;
                        break;
                    case "Carrot":
                        Carrot carrot1 = new Carrot();
                        carrot1 = (Carrot)item;
                        Name = carrot1.Name;
                        break;
                    case "onion":
                        onion onion1 = new onion();
                        onion1 = (onion)item;
                        Name = onion1.Name;
                        break;
                    default:
                        Name = "";
                        break;

                }
                Console.WriteLine(Name+" "+item.QuantityProduct + " "+ item.UnitProduct+" Калорийность продукта: "+item.CalorieTo100()+" ккал");
                Cal += item.CalorieTo100();
            }
            sup.CalorieDish += Cal;
            Console.WriteLine("Калорийность блюда: "+sup.CalorieDish+" ккал");
            Console.WriteLine("Время приготовления "+sup.NameDish+": "+sup.CookingDish_Time);
            Console.WriteLine();
            Console.WriteLine("Приготовление блюда: ");
            foreach(var itemsup in sup.Dishes)
            {
                Console.WriteLine();
                Console.WriteLine("Приготовление: "+itemsup.NameDish);
                Console.WriteLine();
                Console.WriteLine("Состав: ");
                foreach (var itemprod in itemsup.product)
                {
                    string Name;

                    switch (itemprod.GetType().Name)
                    {
                        case "Oil":
                            Oil oil1 = new Oil();
                            oil1 = (Oil)itemprod;
                            Name = oil1.Name;
                            break;
                        case "potatoes":
                            potatoes potatoes1 = new potatoes();
                            potatoes1 = (potatoes)itemprod;
                            Name = potatoes1.Name;
                            break;
                        case "water":
                            water water1 = new water();
                            water1 = (water)itemprod;
                            Name = water1.Name;
                            break;
                        case "Carrot":
                            Carrot carrot1 = new Carrot();
                            carrot1 = (Carrot)itemprod;
                            Name = carrot1.Name;
                            break;
                        case "onion":
                            onion onion1 = new onion();
                            onion1 = (onion)itemprod;
                            Name = onion1.Name;
                            break;
                        default:
                            Name = "";
                            break;

                    }
                    Console.WriteLine(Name + " " + itemprod.QuantityProduct + " " + itemprod.UnitProduct + " Калорийность продукта: " + itemprod.CalorieTo100() + " ккал");
                }
                Console.WriteLine("Калорийность: "+itemsup.CalorieDish+" ккал");
                Console.WriteLine("Время приготовления: "+itemsup.CookingDish_Time);
                Console.WriteLine(itemsup.СookingDish);
            }
            Console.WriteLine();
            Console.WriteLine("Приготовление "+sup.NameDish+":");
            Console.WriteLine(sup.СookingDish);
            Console.ReadLine();

        }
    }
}
