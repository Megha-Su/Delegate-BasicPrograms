using System;

namespace DelegateBasicPrgm4
{
    public delegate void SumDelegate(int firstnumber,int secondnumber);
    class Program
    {
        public static void Sum(int firstnumber, int secondnumber) 
        {
            var sum = firstnumber + secondnumber;
            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            var sumdelegate = new SumDelegate(Sum);
            sumdelegate(20,9);

        }
    }
}
