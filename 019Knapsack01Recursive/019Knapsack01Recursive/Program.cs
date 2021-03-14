using System;

namespace Knapsack01Recursive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] profits = { 1, 6, 10, 16 }; // The values of the jewelry
            int[] weights = { 1, 2, 3, 5 }; // The weight of each
            int profitsLength = profits.Length;
            int weightsLength = weights.Length;
            int startIndex = 0;
            Console.WriteLine("Total knapsack profit ---> " +
            "" + KnapSack(  profits,
                            profitsLength,
                            weights,
                            weightsLength,
                            7,
                            startIndex));

            Console.WriteLine("Total knapsack profit ---> " +
            "" + KnapSack(profits,
                            profitsLength,
                            weights,
                            weightsLength,
                            6,
                            startIndex));

            Console.ReadLine();
        }
        public static int KnapsackRecursive(int[][] lookUpTable, int[] profits,
            int profitsLength, int[] weights,
            int weightsLength, int capacity, int currentIndex)
        {
            
            // base checks  
            if (capacity <= 0 || currentIndex >= profitsLength || currentIndex < 0
                || weightsLength != profitsLength)
                return 0;

            // if we have already solved the subproblem, return the result from the table  
            if (lookUpTable[currentIndex][capacity] != 0)
                return lookUpTable[currentIndex][capacity];

            int profit1 = 0;
            //If the weight of the current item is more than knapsack capacity,
            //then this item can not be included in the knapsack
            if (weights[currentIndex] <= capacity)
            {
                //If the decision is to take the the item,
                //add the profit of the item
                //reduce the capacity
                //and move to next item
                profit1 = profits[currentIndex]
                          + KnapsackRecursive(lookUpTable,
                                     profits,
                                     profitsLength,
                                     weights,
                                     weightsLength,
                                     capacity - weights[currentIndex],
                                     currentIndex + 1);
            }

            //If the decision is to NOT take the item, just move to next item
            int profit2 = KnapsackRecursive(lookUpTable,
                                     profits,
                                     profitsLength,
                                     weights,
                                     weightsLength,
                                     capacity,
                                     currentIndex + 1);

            //Return the maximum of the two profits in above 2 decisions
            lookUpTable[currentIndex][capacity]= Math.Max(profit1, profit2);
            return lookUpTable[currentIndex][capacity];
        }
        public static int KnapSack(int[] profits,int profitsLength, int[] weights,
            int weightsLength, int capacity, int currentIndex)
        {
            //Create a jagged array and the purpose is to get the value
            //from last cell of the array
            int[][] lookUpTable = new int[profitsLength][];

            for (int i = 0; i < profitsLength; i++)
            {
                lookUpTable[i] = new int[capacity + 1];
                for (int j = 0; j < capacity+1; j++)
                {
                    lookUpTable[i][j] = 0;
                }
            }

            return KnapsackRecursive(lookUpTable, profits, profitsLength,
                weights,weightsLength, capacity, currentIndex);


        }
            
        
    }
}
