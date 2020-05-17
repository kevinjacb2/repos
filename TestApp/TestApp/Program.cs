using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomWidth, roomLength;
            double pricePerSqYard, noOfSquareYard, finalPrice;
            GetDimension(out roomLength, out roomWidth);
            pricePerSqYard = Getprice();
            noOfSquareYard = DetermineSquareYards(roomWidth, roomLength);
            finalPrice = DeterminePrice(noOfSquareYard, pricePerSqYard);
            Console.WriteLine("Total square yard needed {0}", noOfSquareYard);
            Console.WriteLine("Total Cost at {0}", finalPrice);
        }


        //Method to Prompt the user to enter length and width
        public static void GetDimension(out double length, out double width)
        {
            Console.WriteLine("Enter the Length of the room");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of the room");
            width = double.Parse(Console.ReadLine());
        }
        //Method to Prompt the user to enter the price
        public static double Getprice()
        {
            string inputValue;
            double price;
            Console.WriteLine("Enter the price per Square Yard :");
            inputValue = Console.ReadLine();
            price = double.Parse(inputValue);
            return price;
        }
        //Method to calculate the area of the room and converting to square yards
        public static double DetermineSquareYards(double width, double length)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            double noOfSquareYards;
            noOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
            return noOfSquareYards;
        }

        //Method to calculate the total price of carpetting the whole room
        public static double DeterminePrice(double squareYards, double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }
    }
}
