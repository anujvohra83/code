using System;

namespace Knapsack01Optimized
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] profits = { 1, 6, 10, 16 }; // The values of the jewelry
            int[] weights = { 1, 2, 3, 5 }; // The weight of each
            int profitsLength = profits.Length;
            int weightsLength = weights.Length;
            //int startIndex = 0;
            Console.WriteLine("Total knapsack profit ---> " +
            "" + Knapsack(profits,
                            profitsLength,
                            weights,
                            weightsLength,
                            7
                            ));

            Console.WriteLine("Total knapsack profit ---> " +
            "" + Knapsack(profits,
                            profitsLength,
                            weights,
                            weightsLength,
                            6
                            ));

            Console.ReadLine();
        }
        public static int Knapsack(int[] profits,
            int profitsLength, int[] weights,
            int weightsLength, int capacity)
        {

            // base checks  
            if (capacity <= 0 || profitsLength == 0 || weightsLength != profitsLength)
                return 0;

            int[] lookupTable = new int[capacity + 1];

            // if we have only one weight, we will take it if it is not more
            // than the capacity

            for (int c = 0; c <= capacity ; c++)
            {
                if (weights[0] <= c)
                {
                    lookupTable[c] = profits[0];
                }
            }
            
            // process all sub-arrays for all the capacities
            for (int i = 1; i < profitsLength; i++)
            {
                for (int c = capacity; c >= 0; c--)
                {
                    int profit1 = 0, profit2 = 0;
                    // include the item, if it is not more than the capacity
                    if (weights[i] <= c)
                        profit1 = profits[i] + lookupTable[c - weights[i]];
                    // exclude the item
                    profit2 = lookupTable[c];
                    // take maximum
                    lookupTable[c] = Math.Max(profit1, profit2);
                }
                
            }
            return lookupTable[capacity];
            /*   for (int i = 1; i < profitsLength; i++)
               {
                   for (int c = capacity; c >= 0; c--)
                   {
                       int profit1 = 0; int profit2 = 0;
                       // include the item, if it is not more than the capacity
                       if(weights[i]<=c)
                       {
                           profit1 = profit1 + lookupTable[c - weights[i]];

                           profit2 = lookupTable[c];

                           lookupTable[c] = Math.Max(profit1, profit2);
                       }
                       return lookupTable[capacity];
                   }
               }*/
        }
    }
}