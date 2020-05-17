using System;

namespace ConvertMilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            Console.WriteLine("Please enter miles");
            miles = Convert.ToDouble(Console.ReadLine());

            double kmsconverted = CalcKms(miles);
            Console.WriteLine($"total is {kmsconverted}");

        }
        private static double CalcKms(double miles)
        {
            double kms;
            const double CONVERTOKMS = 1.69034;  
            kms = miles * CONVERTOKMS;
            return kms;

        }
    }
}
