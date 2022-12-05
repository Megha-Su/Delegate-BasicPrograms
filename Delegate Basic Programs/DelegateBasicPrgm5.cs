using System;

namespace DelegateBasicPrgm5
{

    public delegate int SumDelegate(int firstnumber,int secondnumber);

   
    class Program
    {
        public static int Sum(int firstnumber, int secondnumber)
        {
            int sum = firstnumber + secondnumber;
            return sum;

        }
        static void Main(string[] args)
        {
            var sumdelegate = new SumDelegate(Sum);
            var sum = sumdelegate(35, 7);
            Console.WriteLine(sum);

        }
    }
}
