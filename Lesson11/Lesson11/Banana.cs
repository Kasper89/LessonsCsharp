using System;

namespace Lesson11
{
    public class Banana<T,TT>:Product<T,TT>
    {
        public Banana(string name, T volume,TT energy):base(name,volume,energy)
        {

        }
    }
}
