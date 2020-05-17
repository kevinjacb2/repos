using System;

namespace DeltaApp_Version2
{
    class Program
    {
        static void Main(string[] args)
        {

            int month, count, intmural, extmural, extprice, intprice, totalRevenue; // Declaration of the variables
            string userInput;
            const int EXTMURAL1 = 699; // Constant Variables declared for calculating the value according to business requirements
            const int EXTMURAL2 = 750;
            const int INTMURAL1 = 450;
            const int INTMURAL2 = 500;
            int lscp_counter = 0; // intialization of variables for counting the input from the user
            int sscpe_counter = 0;
            int abs_counter = 0;


            Console.WriteLine("**************Task 1**************"); //Task 1 begins
            Console.WriteLine("Please enter the month"); // prompting the input from the user
            month = Convert.ToInt32(Console.ReadLine()); // reading the input from the user

            while (month < 1 || month > 12) //logic for checking the validity of the month as the value should be between 1- 12
            {


                Console.WriteLine("Please enter a valid month"); // Prompting the user again if the input is invalid
                month = Convert.ToInt32(Console.ReadLine());// Reading the value from the user

            }
            Console.WriteLine("**************Task 2**************");// task 2 begins

            Console.WriteLine("Enter number of interior murals which are to be Scheduled"); // Prompting the user to enter the number of interior murals
            intmural = Convert.ToInt32(Console.ReadLine()); // reading the input from the user for interior murals

            while (intmural > 20 || intmural < 0) // logic for checking if the input from the user is between 0-20
            {
                Console.WriteLine("Please enter a value between 0 to 20 for Interior Murals ");// if the input is invalid the user will be prompted again to enter the valid input
                intmural = Convert.ToInt32(Console.ReadLine());//reading the input from the user again

            }

            Console.WriteLine("enter number of Exterior murals which are to be scheduled");// Prompting the user to enter the number of Exterior murals
            extmural = Convert.ToInt32(Console.ReadLine());// reading the input from the user for exterior murals

            while (extmural > 20 || extmural < 0) // logic for checking if the input from the user is between 0-20

            {
                Console.WriteLine("Please enter a value between 0 to 20 for Exterior Murals");// if the input is invalid the user will be prompted again to enter the valid input
                extmural = Convert.ToInt32(Console.ReadLine()); //reading the input from the user again

            }

            Console.WriteLine("**************TASK 3**************"); //Task 3 begins


            if (month == 7 || month == 8) // checking the value of month from task1 to calculate the value as per business requirement if the month is 7 or 8 the price of each interior murals would be $450
            {
                intprice = intmural * INTMURAL1; // Calculating the value if month is 7 or 8
                Console.WriteLine("{0} interior murals are scheduled at the rate of {1} which amounts to {2}", intmural,INTMURAL1.ToString("C"), intprice.ToString("C")); // giving the output to the user
            }

            else

            {
                intprice = intmural * INTMURAL2; // if the value of month is neither 7 nor 8 the default price set as per business requirement is $500
                Console.WriteLine("{0} interior murals are scheduled at the rate of {1} which amounts to {2}",intmural,INTMURAL2.ToString("C"), intprice.ToString("C"));// giving the output to the user 

            }


            if (month == 4 || month == 5 || month == 9 || month == 10)// Checking the condition given specifically for exterior murals 

            {

                extprice = extmural * EXTMURAL1; // calculating the values taking the value of each exterior murals as $699

                Console.WriteLine("{0} exterior murals are scheduled at the rate of {1} which amounts to {2}", extmural,EXTMURAL1.ToString("C"),extprice.ToString("C"));//giving the output to the user

            }
            else if ((month == 12 || month == 1 || month == 2)) //Checking the condition given as per business requirement 
            {
                extmural = 0; // the value of exterior mural in the month value 12, 1 & 2 is zero
                extprice = extmural * EXTMURAL1; // calculating the price

                Console.WriteLine("{0} exterior murals are scheduled at the rate of $0 which amounts to {1}",extmural, extprice.ToString("C")); //giving the output to the user

            }

            else
            {
                extprice = extmural * EXTMURAL2; // if the month value isnt as mentioned in above conditions then the default value of each exterior murals is $750
                Console.WriteLine("{0} exterior murals are scheduled at the rate of  {1} which amounts to {2}",extmural,EXTMURAL2.ToString("C"), extprice.ToString("C")); //giving the output to the user
            }


            totalRevenue = intprice + extprice;//calculating the total revenue

            Console.WriteLine("The total revenue generated is {0}", totalRevenue.ToString("C")); // giving the output to the user


            Console.WriteLine("**************TASK 4**************");// task 4 begins


            

            for (count = 0; count < intmural; count++)  //as we know the number of interior murals given by the user we would use for loop and put these conditions


            {

                Console.WriteLine("Enter customer name");//prompting the user as per business requirement
                Console.ReadLine();
                Console.WriteLine(" L for Landscape");
                Console.WriteLine(" S for Seascape");
                Console.WriteLine(" A for Abstract");
                userInput = Console.ReadLine();
                while ((userInput != "L" && userInput != "A" && userInput != "S")) // condition for validating the input from the user

                {
                    Console.WriteLine("{0} is not a valid input, Please try again", userInput); // if the values provided by the user are invalid then the user will be prompted again
                    Console.WriteLine("Please re-enter the style of murals");
                    Console.WriteLine(" L for Landscape");
                    Console.WriteLine(" S for Seascape");
                    Console.WriteLine(" A for Abstract");
                    userInput = Console.ReadLine();


                }
                if (userInput == "L") // logic for counting the number of times user entered "L"
                {
                    lscp_counter = (lscp_counter + 1);
                }

                else if (userInput == "A") // logic for counting the number of times user entered "A"

                {
                    sscpe_counter = (sscpe_counter + 1);
                    
                }

                if (userInput == "S") // logic for counting the number of times user entered "S"

                {
                    abs_counter = (abs_counter + 1);

                }
            }
            Console.WriteLine("Number of Customers who choose Landscape interior murals are {0}", lscp_counter); //giving the output to the user.
            Console.WriteLine("Number of Customers who choose Seascape interior murals are {0}", sscpe_counter);
            Console.WriteLine("Number of Customers who choose Abstract interior murals are {0}", abs_counter);
            // Kevin Jacob Mylakkattu Student No n10654704
        }
    }
}
    
