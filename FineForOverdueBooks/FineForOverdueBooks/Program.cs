using System;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            double NoOfBooks;
            double NoOfDays;
            Console.WriteLine("Please enter the number of books");
            NoOfBooks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of days the boooks are due");
            NoOfDays = Convert.ToDouble(Console.ReadLine());





        }
        private static double CalcFine(double fines, double NoOfDays, double NoOfDays)

        double fines;
        const int FIRSTFINE = 10;
        const int SECONDFINE = 20;
        const int FIRSTFINEDAYS = 7;

        if (NoOfDays > FIRSTFINEDAYS)
            
            {
              fines = NoOfDays* FIRSTFINE;

    }
    else 
     
    {
            fines = NoOfDays* SECONDFINE; 

}

    }
}
