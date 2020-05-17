using System;

namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstInt  =  1 ;
            int middleInt =  2 ; 
            int LastInt   =  3 ;

            Console.WriteLine("The values are {0}, {1} & {2}",FirstInt,middleInt,LastInt);
             ReverseNumbers( ref FirstInt, ref LastInt, ref middleInt);
            Console.WriteLine("The values are now {0}, {1} & {2}", FirstInt, middleInt, LastInt);

        }
        public static void ReverseNumbers( ref int FirstInt, ref int LastInt, ref int middleInt)
        {
            int temp;
            temp = FirstInt;
            FirstInt = LastInt;
            LastInt = temp ;
            Console.WriteLine("The value is {0}, {1} & {2}", FirstInt, middleInt, LastInt);
        }
    }
}
