using System;

namespace Assessment1
{
    class KMPHConverter
    {
        static void Main()
        {
            double milesPerHour, kiloMeterPerHour;
            double finalKmph;
            DisplayInstructions();
            GetSpeedFromtheUser(out milesPerHour);
            finalKmph = ConvertMPHToKMPH(milesPerHour , out kiloMeterPerHour);
            DisplaySpeed(milesPerHour, kiloMeterPerHour);
        }

        // Method Display Instructions to the user
        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will determine to convert mph to km/h");
            Console.WriteLine();
            Console.WriteLine("You will be asked to enter a value for mph");
            Console.WriteLine();
        }
        // Method Prompt the user to give input for the Miles per hour
        public static void GetSpeedFromtheUser(out double mph)
        {
            Console.WriteLine("Enter the mph of the car");
            mph = double.Parse(Console.ReadLine());
          
        }
        //Method to Convert miles per hour to kilometer per hour
        public static double ConvertMPHToKMPH(  double mph , out double kmph)
        {
            const double MPHCONVERTER = 1.609344;
            kmph = MPHCONVERTER * mph;
            return kmph;
        }
        // Method to display the user Miles per hour and Kilometers per hour
        public static void DisplaySpeed( double mph , double kmph)
        {
            Console.WriteLine("Mph to Kmph Conversions  Speed/velocity conversions");
            Console.WriteLine();
            Console.Write("MPH                 KM/H");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("{0}               {1:F4} ",mph ,kmph);
        }

    }
}
