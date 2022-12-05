using System;

namespace Delegate_BasicPrgm_with_string_return_
{
    public delegate string stringdelegate();
    class Program
    {
        public static string Text()
        {

            return "Hello";
         
        }
        public static void  Main(string[] args)
        {

          var text= new stringdelegate(Text);
          string msg = text();
          Console.WriteLine(msg);

        }
    }
}
