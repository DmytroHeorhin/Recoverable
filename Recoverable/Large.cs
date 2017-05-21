using System;

namespace Recoverable
{
    public class Large
    {
        private readonly int _id;

        public Large(int id)
        {
            _id = id;
            var field = new byte[0x1400000];
            Console.WriteLine("Large object #{0} has been created.", _id);
            field = null;
        }

        ~Large()
        {
            Console.WriteLine("Large object #{0} has been garbage collected!", _id);
            Program.Nullify();
        }
    }
}
