using System;

namespace Recoverable
{
    public class Program
    {
        private static Recoverable _recoverableObject;

        private static void Main(string[] args)
        {
            Allocate();
            Nullify();
            for (var i = 1; i < 100; i++)
            {
                var largeObject = new Large(i);
            }
        }

        public static void Allocate()
        {
            _recoverableObject = new Recoverable();
        }

        public static void Recover(Recoverable recoverableObject)
        {
            _recoverableObject = recoverableObject;
            GC.ReRegisterForFinalize(_recoverableObject);
            Console.WriteLine("###### Recoverable object has been recovered.");
        }

        public static void Nullify()
        {
            if (_recoverableObject != null)
            {
                _recoverableObject = null;
                Console.WriteLine("******* Reference to recoverable object has been set to null.");
            }
        }
    }
}