using System;

namespace Lesson12
{
    class SuperCar:BMWSeven,ICar
    {

        int ICar.Move(int distance)
        {
            throw new NotImplementedException();
        }

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

        void IObject.Create()
        {
            throw new NotImplementedException();
        }
    }
}
