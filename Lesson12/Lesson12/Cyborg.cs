using System;

namespace Lesson12
{
    public class Cyborg:ICar,IPerson
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

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }

        public void Create() { }
    }
}
