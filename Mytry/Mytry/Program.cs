using System;

namespace Mytry
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomWidth, roomLength, pricePerSqYard, noOfSquareYards;
        }
        public static void GetDimension(out double length, out double width)


        {
            Console.WriteLine("Enter the length");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            width = double.Parse(Console.ReadLine());
        
        }
        public static double GetPrice()
        {
            string inputValue;
            double price;
            Console.WriteLine("Enter the price per square yard");
            inputValue = Console.ReadLine();
            price = double.Parse(inputValue);
            return price;
        
        }

        public static double DetermineSqyards(double length, double width)

        {
            const int SQ_FT = 9;
            double 
        
        }
    }
}
