using System;

namespace InputMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            Console.WriteLine("After InputMethod first is {0}",first);
            Console.WriteLine("and second is {0}", second);
        }
        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }

        private static int DataEntry(string Kuchbhi)
        {
            int one;
            string s1;
            Console.WriteLine("Enter {0} integer",Kuchbhi);
            s1 = Console.ReadLine();
            one = Convert.ToInt32(s1);
            return one;
        }
    }
}
