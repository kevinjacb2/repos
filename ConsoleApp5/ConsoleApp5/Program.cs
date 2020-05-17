using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            int month, count, intmural, extmural, extprice, intprice, totalRevenue;
            string userInput;
            const int a = 699;
            const int b = 750;
            int lscp_counter = 0;
            int sscpe_counter = 0;
            int abs_counter = 0;
            Console.WriteLine("**************Task 1**************");
            Console.WriteLine("Please enter the month");
            month = Convert.ToInt32(Console.ReadLine());

            while (month < 1 || month > 12)
            {


                Console.WriteLine("Please enter a valid month");
                month = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("*******Task 2*******");

            Console.WriteLine("enter number of interior murals sc");
            intmural = Convert.ToInt32(Console.ReadLine());

            while (intmural > 20 || intmural < 0)
            {
                Console.WriteLine("Please enter a valid month");
                intmural = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("enter number of interior murals sc");
            extmural = Convert.ToInt32(Console.ReadLine());

            while (extmural > 20 || extmural < 0)

            {
                Console.WriteLine("enter number of exterior murals sc");
                extmural = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("****************TASK 3*************************");


            if (month == 7 || month == 8)
            {
                intprice = intmural * 450;
                Console.WriteLine("the value of interior murals {0}", intprice);
            }

            else

            {
                intprice = intmural * 500;
                Console.WriteLine("the value of interior murals {0}", intprice);

            }


            if (month == 3 || month == 4 || month == 9 || month == 10)

            {

                extprice = extmural * a;

                Console.WriteLine("the value of exterior murals {0}", extprice);

            }
            else if ((month == 12 || month == 1 || month == 2))
            {
                extmural = 0;
                extprice = extmural * a;

                Console.WriteLine("the value of exterior murals {0}", extprice);

            }

            else
            {
                extprice = extmural * b;
                Console.WriteLine("the value of exterior murals {0}", extprice);
            }


            totalRevenue = intprice + extprice;

            Console.WriteLine("The total revenue generated is {0}", totalRevenue);


            Console.WriteLine("***********TASK 4**********");


            Console.WriteLine("Entering interior jobs");
            Console.WriteLine("Enter customer name");

            for (count = 0; count < 4; count++)


            {


                Console.WriteLine(" L for Landscape");
                Console.WriteLine(" S for Seascape");
                Console.WriteLine(" A for Abstract");
                userInput = Console.ReadLine();
                while ((userInput != "L" && userInput != "A" && userInput != "S"))

                {
                    Console.WriteLine("{0} is not a valid input", userInput);
                    Console.WriteLine("Please re-enter the style of murals");
                    userInput = Console.ReadLine();


                }
                if (userInput == "L")
                {
                    lscp_counter = (lscp_counter + 1);
                    Console.WriteLine("{0}", lscp_counter);
                }

                else if (userInput == "A")

                {
                    sscpe_counter = (sscpe_counter + 1);
                        Console.WriteLine("{0}", sscpe_counter);
                }

                if (userInput == "S")

                {
                    abs_counter = (abs_counter + 1);
                    Console.WriteLine("{0}", abs_counter);
                }
            }

        }
    }
}

