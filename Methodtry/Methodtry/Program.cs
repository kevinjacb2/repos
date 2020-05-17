using System;

namespace Methodtry
{
    class Program
    {
        static void Main(string[] args)
        {
            char code;
            Console.WriteLine("Hello World! enter a char");
            code = Convert.ToChar(Console.ReadLine());
            Method(code);
            Console.WriteLine("The Char u entered is {0}",code);
        }

        static void Method(char cde)
        {
            const double FULLTIME = 15.55;
            const double PARTIME = 11.15;
       
            if (cde == 'F')
                Console.WriteLine(" rate is {0}", FULLTIME);
            else
                Console.WriteLine("rate is {0}", PARTIME);
            cde = 'X';
            Console.WriteLine("Rate is {0}", cde);



        }
    }
}

