using System;

namespace Lesson11
{
    public class Apple<T,TT>:Product<T,TT>
    {
        public Apple(string name, T volume,TT energy):base(name,volume,energy)
        {

        }
    }
}
