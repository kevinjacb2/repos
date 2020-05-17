using System;

namespace X
{
    class Program
    {

        static void Main(string[] args)
        {
            int month;
            int month_start = 1;
            int month_end = 12;
            int interior_murals;
            int exterior_murals;
            int range_start = 0;
            int range_end = 20;
            const int total_exterior = 750;
            const int total_exterior2 = 699;
            const int total_interior = 450;
            const int total_interior2 = 500;
            int total_revenue;
            int  b;
            int exterior_price = 0;
            string name;
            char code;


            Console.WriteLine("Enter the month");
            month = Convert.ToInt32(Console.ReadLine());

            while (month < month_start || month > month_end)
            {

                {
                    Console.WriteLine("Invalid Month.Enter the month");
                    month = Convert.ToInt32(Console.ReadLine());
                }


            }

            Console.WriteLine("******************** Task 2 **************************");

            Console.WriteLine(" enter number of interior murals scheduled");
            interior_murals = Convert.ToInt32(Console.ReadLine());

            while (interior_murals < range_start || interior_murals > range_end)
            {
                Console.WriteLine("Number must be between 0 and 20 inclusive");
                interior_murals = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine(" enter number of exterior murals scheduled");
            exterior_murals = Convert.ToInt32(Console.ReadLine());

            while (exterior_murals < range_start || exterior_murals > range_end)
            {
                Console.WriteLine("Number must be between 0 and 20 inclusive");
                exterior_murals = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("******************** Task 3 **************************");
            { 
            if (month == 7 || month == 8)
            {
                
                b = 699 * interior_murals;
                Console.WriteLine("{0} interior murals are scheduled at {1}$ each for a total of {2}$ ", interior_murals,  b);
            }

            else
            {
                
                b = 750 * interior_murals;
                Console.WriteLine("{0} interior murals are scheduled at {1}$ each for a total of {2}$ ", interior_murals,  b);
            }

                if (month == 12 || month == 1 || month == 2)
                {
                    exterior_murals = 0;

                    Console.WriteLine("{0} exterior murals are scheduled at {1}$ each for a total of {2}$", exterior_murals, exterior_murals); ;

                }

                else if (month == 4 || month == 5 || month == 9 || month == 10)
                {

                    exterior_price = 450 * exterior_murals;
                    Console.WriteLine("{0} exterior murals are scheduled at {1}$ each for a total of {2}$ ", exterior_murals, exterior_price);

                }
                else
                {

                    exterior_price = 500 * exterior_murals;
                    Console.WriteLine("{0} exterior murals are scheduled at {1}$ each for a total of {2}$ ", exterior_murals, exterior_price);

                }

                {
                    total_revenue = (exterior_price + b);
                    Console.WriteLine("{0}", total_revenue);
                }
            }

       




            Console.WriteLine("******************** Task 4 **************************");

            Console.WriteLine("Entering interior jobs");
            Console.WriteLine("Enter customer name");
            name = Console.ReadLine();
            Console.WriteLine("Mural option are");
            Console.WriteLine(" L for Landscape");
            Console.WriteLine(" S for Seascape");
            Console.WriteLine(" A for Abstract");


            Console.WriteLine("Enter mural style code");
            code = Convert.ToChar(Console.ReadLine());

            while (code != 'L' && code != 'S' && code != 'A')
            {
                Console.WriteLine("{0} is not a valid code", code);
                Console.WriteLine("Enter mural style code");
                code = Convert.ToChar(Console.ReadLine());


            }



        }
    }
}
