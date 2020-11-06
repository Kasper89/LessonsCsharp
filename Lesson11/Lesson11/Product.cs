using System;

namespace Lesson11
{
    public class Product<T,TT>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public TT Energy { get; set; }

        public Product(string name, T volume, TT energy)
        {
            //TODO: Проверить входные параметры.
            Name = name;
            Volume = volume;
            Energy = energy;
        }

        public Product(string name, T volume)
        {
            //TODO: Проверить входные параметры.
            Name = name;
            Volume = volume;
            Energy = default(TT);
        }
    }
}
