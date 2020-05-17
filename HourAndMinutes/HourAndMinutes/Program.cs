using System;

namespace HourAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONVMIN = 60; /*Declaring constant variable CONVMIN with integer datatype 60 */
            int userInput, min, hour; /*Declaring variables with integer datatype as double will return values after decimal point */

            Console.WriteLine("Please enter the no of minutes worked"); /*Prompting the user for input*/
            userInput = Convert.ToInt32(Console.ReadLine());/* as the default input from the user is a string we need to convert that to integer datatype for further calculation */
            hour = userInput / CONVMIN; /*Dividing the user input by constant variable "CONVMIN" then assigning that value to variable "hour" */
            min = userInput % CONVMIN;  /*Assigning the value of remainder to the variable "min" */
            Console.WriteLine("The total time worked is {0} hour ,{1} mins", hour, min); /*Displaying the output to the user */
        }
    }
}
