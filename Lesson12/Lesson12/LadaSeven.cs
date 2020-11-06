using System;

namespace Lesson12
{
    public class LadaSeven:ICar
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
            return distance / 40;
        }
        public void Create() { }
    }
}
