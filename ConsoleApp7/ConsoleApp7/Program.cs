using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            int first, second;
            InputMethod(out first, out second);

        }
        private static void InputMethod (out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }
        public static int DataEntry(String String)
        {
            int one;
            string s1;
            Console.WriteLine("");
            s1 = Console.ReadLine();
            one = Convert.ToInt32(s1);
            return one;
        }
    }
}
