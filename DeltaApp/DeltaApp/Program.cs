using System;
using static System.Console;

namespace DeltaApp
{
    class Program
    {
        static void Main(string[] args)
        {
                //Declaration of variables with data types
                bool Comparision;
                const uint INTRMURAL = 500;
                const uint EXTRMURAL = 750;
                uint userInputForInterior, userInputForExterior;
                Double CalcRevenue;
               

                WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");// Question 1 printing "M" on borders with company motto in the centre 
                WriteLine("M                                                                        M");
                WriteLine("M                  Make your vision your view.                           M");
                WriteLine("M                                                                        M");
                WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");


                WriteLine("Please enter the number of interior murals to be painted during next month"); // Prompting the user to input value for interior murals
                userInputForInterior = Convert.ToUInt32(ReadLine()); 
                WriteLine("Please enter the number of interior murals to be painted during next month"); //Promting the user to input value for exterior murals
                userInputForExterior = Convert.ToUInt32(ReadLine());
                

                CalcRevenue = (INTRMURAL * userInputForInterior) + (EXTRMURAL * userInputForExterior); // Logic for calculating revenue for murals.

                 
                WriteLine("The expected revenue is ${0}", CalcRevenue.ToString("C")); // formatting floating point values

                Comparision = userInputForInterior >= userInputForExterior;  //logic for comparing values for interior and exterior

                WriteLine(" It is {0} that interior is greater than exterior", Comparision); //output without using if else statment
            

        }
    }
}
