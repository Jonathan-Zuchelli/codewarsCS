using System;

namespace MaximumSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: " + MaxSeq(new int[]{-2, 1, -3, 4, -1, 2, 1, -5, 4}));
        }

        public static int MaxSeq(int[] arr){
            int bestSum = 0;
            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++){
                currentSum = Math.Max(0, currentSum + arr[i]);
                bestSum = Math.Max(bestSum, currentSum);
            }
            return bestSum;
        }
    }    
}
