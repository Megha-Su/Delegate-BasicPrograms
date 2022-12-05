using System;

namespace DelegateBasicPrgm_one_argument_and_one_void_
{
    public delegate void NumDelegate(int number);
    class Program
    {

        public static void SqrNum(int number) 
        {

            Console.WriteLine(number * number);
    
        }


        static void Main(string[] args)
        {
           
            var numberDel = new NumDelegate(SqrNum);
            numberDel(5);

        }
    }
}
