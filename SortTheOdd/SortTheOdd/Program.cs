using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Console.ReadLine();
        }

        public static int[] SortArray(int[] array)
        {
            var odds = array.Where(item => item % 2 != 0).OrderBy(item => item).ToList();
            int[] result = new int[array.Length];
            int i = 0;

            for (int j = 0; j < array.Length; j++) { 
                if (array[j] % 2 == 0)
                {
                    result[j] = array[j];
                }
                else
                {
                    result[j] = odds[i];
                    i++;
                }
            }    

            return result;
        }
    }
}
