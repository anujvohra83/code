/*
 
 Problem statement #
    A child is running up a staircase with n steps and
    can hop either 1 step, 2 steps, or 3 steps at a time.
    Implement a function to count the number of possible ways
    that the child can run up the stairs.

Input #
    An integer that represents the number of stairs

Output #
    An integer that represents the number of ways that
    those stairs can be climbed

 */
using System;

namespace StaircaseProblem3Step
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int stairCount = 18;
            long count = CountWays(stairCount);
            Console.WriteLine($"Number of possible ways that the child " +
                $"can run up the {stairCount} stairs: {count} ");
           
        }
        public static long CountWays(int n)
        {
            long[] lookupTable = new long[n + 1];

            lookupTable[0] = 0;
            lookupTable[1] = 1;
            lookupTable[2] = 2;

            for (int i = 3; i <= n; i++)
            {
            lookupTable[i] = lookupTable[i - 1] + lookupTable[i - 2] + lookupTable[i - 3];
            }

            return lookupTable[n];
        }
    }
}
