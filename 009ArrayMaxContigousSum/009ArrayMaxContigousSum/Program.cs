using System;
using System.Collections.Generic;

namespace ArrayMaxContigousSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1 ,2, 3, -2, 5 };
            int maxsum = Kadane(array01);

            Console.Write($"Maximum Contigous Sum of subarray is : {maxsum}");

        }
        static int Kadane(int[] array01)
        {
            int maxSum = array01[0]; // set to first element
            int newsum = array01[0]; // set to first element


            for (int i = 1; i < array01.Length; i++)
            {
                // keep adding the sum of previous and current element
                newsum = newsum + array01[i];

                //Take a maximum of current element and sum of (previous sum
                //+ current element)
                newsum = Math.Max( array01[i], newsum);

                // take the maximum of sub array sum and previous maximum sum
                if (newsum > maxSum)
                {
                    maxSum = newsum;
                }
                    
            }
            return maxSum;
        }

    }
}
