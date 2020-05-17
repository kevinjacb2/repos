using System;

namespace ByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomWidth, roomLength;
            double pricePerSqYard, noOfSquareYard, finalPrice;
            GetDimension(out roomLength, out roomWidth);
            pricePerSqYard = Getprice();
            noOfSquareYard = DetermineSquareYards(ref roomWidth, ref roomLength);
            finalPrice = DeterminePrice(ref noOfSquareYard, ref pricePerSqYard);
            Console.WriteLine("Total square yard needed {0}", noOfSquareYard);
            Console.WriteLine("Total Cost at {0}", finalPrice);
        }
        public static void GetDimension(out double length, out double width)
        {
            Console.WriteLine("Enter the Length of the room");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of the room");
            width = double.Parse(Console.ReadLine());
        }

        public static double Getprice()
        {
            string inputValue;
            double price;
            Console.WriteLine("Enter the price per Square Yard :");
            inputValue = Console.ReadLine();
            price = double.Parse(inputValue);
            return price;
        }
        public static double DetermineSquareYards( ref double width,  ref double length)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            double noOfSquareYards;
            noOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
            return noOfSquareYards;
        }
        public static double DeterminePrice(ref double squareYards, ref double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }
    }
}
