using System;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arreyyyy = {4,4,5,5,6,6,7,7,8,8,9,9};
            Averages(arreyyyy);
            Averages(3);
            Averages(12, 15);
            Averages(22.3,44.5,88.5);
        }
        public static void Averages(params double[] arreyyyy)
        {
            double total = 0;
            double avg;
           
            for (int x = 0; x < arreyyyy.Length; x++)

            {
                Console.WriteLine("{0}", arreyyyy[x]);
                total += arreyyyy[x];

            }

            avg = total / arreyyyy.Length;

            Console.WriteLine("Average is {0}",avg);


        }
    }
}
