using System;

namespace Recoverable
{
    public class Recoverable
    {
        public Recoverable()
        {
            Console.WriteLine("+++++++ Recoverable object has been created.");
        }

        ~Recoverable()
        {
            Console.WriteLine("------- Recoverable object is having it's finalizer called...");
            Program.Recover(this);
        }
    }
}
