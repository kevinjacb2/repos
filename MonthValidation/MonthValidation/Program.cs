using System;

namespace MonthValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;

            Console.WriteLine("Input your birth month");
            month = Convert.ToInt32(Console.ReadLine());

            if (((month > 12) && (month < 1)))

            {
                Console.WriteLine("Month is valid");
            }

            else
            {
                Console.WriteLine("{0} Month is an invalid input", month);
            }

        }
    }
}
    
