using System;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Console.ReadLine();
        }

        public static string HighAndLow(string numbers)
        {
            String[] newNumbers = numbers.Split(" ");
            int min = Int32.Parse(newNumbers[0]);
            int max = Int32.Parse(newNumbers[0]);
            foreach (String number in newNumbers)
            {
                min = Math.Min(min, Int32.Parse(number));
                max = Math.Max(max, Int32.Parse(number));
            }
            return max + " " + min;
        }
    }
}
