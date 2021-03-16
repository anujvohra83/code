/*
 Problem statement #
Given an array of integers, write a function to find if any two subsets of the
input array exist such that the sum of both subsets is equal. You can assume
that the array will only consist of positive integers.

Input #
An array of positive integers

Output #
The output is a boolean. It will be True if such subsets exist and False
if they do not

Sample input #
int set[] = {1, 2, 3, 4};
Sample output #
true          // (The 2 subsets will be 1,4 & 2,3)
 */

using System;

namespace ThePartitionProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] set1 = { 1, 2, 3, 4 };
            Console.WriteLine($"Can partition array 1, 2, 3, 4: " +
                $"{CanPartition(set1, set1.Length)}");

            int[] set2 = { 1, 1, 3, 4, 7 };
            Console.WriteLine($"Can partition array 1, 1, 3, 4, 7: " +
                $"{CanPartition(set2, set2.Length)}");

            int[] set3 = { 2, 3, 4, 6 };
            Console.WriteLine($"Can partition array 2, 3, 4, 6: " +
                $"{CanPartition(set3, set3.Length)}");

            
            Console.ReadLine();
        }
        public static Boolean CanPartition(int[] num, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += num[i];
            }

            //If we are paritioning an array,the sum will always be even
            if(sum %2!=0)
            {
                return false;
            }
            

            int[][] lookupTable= new int[length][];
            for (int i = 0; i < length; i++)
            {
                lookupTable[i] = new int[(sum / 2) + 1];
                for (int j = 0; j < (sum / 2) + 1; j++)
                    lookupTable[i][j] = -1;
            }
            return Convert.ToBoolean(CanPartitionRecursive(lookupTable,num, sum / 2, 0));


        }
        public static int CanPartitionRecursive(int[][] lookupTable,
            int[] arr, int sum, int currentIndex)
        {
            int n = arr.Length;

            //base condition
            if (sum == 0)
                return 1;
            if (n == 0 || currentIndex >= n)
                return 0;

            if(lookupTable[currentIndex][sum]==-1)
            {
                if(arr[currentIndex] <=sum)
                {
                    if( CanPartitionRecursive(lookupTable,
                        arr,
                        sum-arr[currentIndex],
                        currentIndex+1)==1)
                    {
                        lookupTable[currentIndex][sum] = 1;
                        return 1;
                    }
                }

                lookupTable[currentIndex][sum] = CanPartitionRecursive(lookupTable,
                        arr,
                        sum,
                        currentIndex + 1);
            }
            return lookupTable[currentIndex][sum];
        }
        
    }
}
