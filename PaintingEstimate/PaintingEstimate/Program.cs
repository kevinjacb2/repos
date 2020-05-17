using System;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double length;

            Console.WriteLine("Please enter width :");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter length:");
            length = Convert.ToDouble(Console.ReadLine());

            double estimate = CalcPrice(width, length);
            Console.WriteLine($"total is {estimate.ToString("C")}");


        }

        private static double CalcPrice(double width, double length)
        {

            const int HEIGHT = 9;
            const double PRICEPERSQUARE = 6;
            double totalpaintingroom = HEIGHT * ((width + length));
            return PRICEPERSQUARE * totalpaintingroom;
        }

    }
}
