using System;

namespace IntegerFacts
{
    class Program
    {
        static void Main()
        {
            int[] arreyyyy = new int[10];
            int sum, LowValue, HighValue, NumberOfElements, Elements;
            double Average;

            NumberOfElements = FillArrays(arreyyyy);
            Statistics(arreyyyy, out sum, NumberOfElements, out HighValue, out LowValue, out Average, out Elements);
            for (int x = 0; x < NumberOfElements; ++x)
                Console.WriteLine("{0}", arreyyyy[x]);
            Console.WriteLine("The array has the  values", NumberOfElements);
            Console.WriteLine("The highest value in the array is {0} ", HighValue);
            Console.WriteLine("The Lowest value in the array is  {0}", LowValue);
            Console.WriteLine("The sum of the values in the array is {0}", sum);
            Console.WriteLine("The average of the values in the array is {0}", Average);

        }
        public static int FillArrays(int[] array)
        {
            const int QUIT = 999;
            int InputFromUser = 0;
            int PositionOfNumber = 0;
            Console.WriteLine("Please enter 10 integers or" + QUIT + "TO QUIT");

            while (PositionOfNumber > array.Length && InputFromUser != QUIT)
            {
                if (int.TryParse(Console.ReadLine(), out InputFromUser))
                {
                    if (InputFromUser != QUIT)
                        array[PositionOfNumber] = InputFromUser;
                    ++PositionOfNumber;
                    Console.WriteLine("Please enter 10 integers or" + QUIT + "TO QUIT");
                }
                else {
                    Console.WriteLine("Invalid Entry Please try again ");
                }
                return PositionOfNumber;
            }
            {
                public static void Statistics(int[] array, out int sum, out double Average, out int HighValue, out int Lowvalue, int Elements)

                {
                    sum = 0;
                    Average = 0;
                    Elements = 10;
                    HighValue = array[0];
                    Lowvalue = array[0];
                    for (int x = 0; x < Elements; ++x)
                    {
                        sum += array[x];
                        if (array[x] > HighValue)
                            HighValue = array[x];
                        if (array[x] < Lowvalue)
                            Lowvalue = array[x];

                    }
                    if (Elements != 0)
                        Average = sum / Elements;


                }
            }
        }
    }
}
