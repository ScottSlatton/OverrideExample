using System;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult scott = new Adult();
            scott.Examine();
        }
    }

    public class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patient is being examined.");
        }
    }

    public class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The Adult is being examined.");
        }
    }
}
