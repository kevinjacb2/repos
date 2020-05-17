using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Square(ref x);
            Console.WriteLine("the value of x is {0}", x);

        }
        static void Square( ref int x)
        {
          
            x *= x; 
        }
    }
}
