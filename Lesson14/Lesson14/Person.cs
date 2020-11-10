using System;

namespace Lesson14
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }


        public void TakeTime(DateTime now)
        {
            if (now.Hour<=8)
            {
                //GoToSleep?.Invoke();//не поддерживает 2013 студия.
                if (GoToSleep!=null)
                {
                    GoToSleep.Invoke();
                }
            }
            else
            {
                var args = new EventArgs();
                //DoWork?.Invoke();//не поддерживает 2013 студия.
                if (DoWork != null)
                {
                    DoWork.Invoke(this,null);
                    //DoWork.Invoke(this, args);
                }
            }
        }

    }
}
