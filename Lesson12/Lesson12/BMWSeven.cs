using System;

namespace Lesson12
{
    public class BMWSeven:ICar
    {
        int ICar.Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Move(int distance)
        {            
            return distance / 100;
        }

        public void Create() { }
    }
}
