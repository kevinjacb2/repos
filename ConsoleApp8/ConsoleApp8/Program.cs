using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Getgpa();
        }
    }
    public static void DisplayInstructions()
    {
        Console.WriteLine("This program will determine to convert mph to km/h");
        Console.WriteLine();
        Console.WriteLine("You will be asked to enter a value for mph");
        Console.WriteLine();
    }
    public static void GetSpeedFromtheUser(out double grades)
    {
        Console.WriteLine("Enter the mph of the car");
        grades = double.Parse(Console.ReadLine());

    }




    public static void Getgpa(params double [] grades)
    {
        const double CONST = 12;
        double sum = 0;
        double score;
        foreach ( double gpa in grades )
        {

            sum += gpa;
            
            Console.WriteLine("YS");
        }

        score = sum / grades.Length;
       
    }

}
