using System;

namespace Delegate_Basic_Programs
{
    public delegate void Namedelegate();
    class Program
    {
        public static  void Name()
        {
            Console.WriteLine("Megha");
        }

        static void Main(string[] args)
        {
            var name = new Namedelegate(Name);
            name();
        }
    }
}
