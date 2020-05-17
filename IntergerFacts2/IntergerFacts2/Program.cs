using static System.Console;

namespace IntergerFacts2
{
    class IntegerFacts
    {
        static void Main()
        {
            int[] nums = new int[10];
            int numEls;
            double avg;
            int sum;
            int high;
            int low;
            numEls = FillArray(nums);
            Statistics(nums, numEls, out high, out low, out sum, out avg);
            for (int x = 0; x < numEls; ++x)
                Write("{0} ", nums[x]);
            WriteLine();
            WriteLine("The array has {0} values", numEls);
            WriteLine("The highest value is {0}", high);
            WriteLine("The lowest value is {0}", low);
            WriteLine("The sum of the values is {0}", sum);
            WriteLine("The average is {0}", avg);



        }

         static int FillArray(int[] nums)
        {
            const int QUIT = 999;
            int entry = 0;
            int pos = 0;
            WriteLine("Please enter an integer or" + QUIT+" to quit ");
            while (pos<nums.Length && entry!=QUIT )
            {
                if (int.TryParse(ReadLine(), out entry))
                {
                    if (entry != QUIT)
                    {
                        nums[pos] = entry;
                        ++pos;
                        Write("Please enter an integer or " + QUIT + "to quit");

                    }
                }
                else
                    Write("Invalid entry Try again");
            }
            return pos;

        }

         static void Statistics(int [] array , int els, out int high, out int low, out int sum ,out double avg )
        {
            sum = 0;
            avg = 0;
         
            low = array[0];
            high = array[0];

            for (int x= 0; x <els; ++x  )
            {
                sum += array[x];
                    if (array[x] > high)
                    high = array[x];
                if (array[x] < low)
                    low = array[x];
            }
            if (els != 0)
                avg = sum *1.0/els;
        }
    }
}
