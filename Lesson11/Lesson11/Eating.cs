using System;

namespace Lesson11
{
    public class Eating<T>
        where T:Product<int,decimal>
    {
        public decimal Volume { get; private set; }

        public T Add(T product)
        {
            Volume += product.Volume * product.Energy;
            return default(T);
        }
    }
}
