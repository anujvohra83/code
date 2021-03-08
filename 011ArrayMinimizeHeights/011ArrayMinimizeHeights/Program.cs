using System;

/*
Given an array arr[] denoting heights of N towers and a positive integer K,
you have to modify the height of each tower either by increasing or decreasing
them by K only once. After modifying, height should be a non-negative integer. 
Find out what could be the possible minimum difference of the height of shortest
and longest towers after you have modified each tower.
*/
namespace ArrayMinimizeHeights
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 8, 1, 5, 4, 7, 5, 7, 9, 4, 6 };
            int n = arr.Length;

            int k = 5;// 3;// 5; //2;

            int min = getMinDiff(arr, n, k);
            Console.WriteLine($"Minimum Heights : {min}");
            Console.ReadLine();
        }
        static int getMinDiff(int[] arr, int n, int k)
        {
            Array.Sort(arr);
            int min, max;
            int minDiff = arr[n - 1] - arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] >= k) // Skip Non-Negative heights
                {
                    max = Math.Max(arr[i-1] + k, arr[n - 1] - k);
                    min = Math.Min(arr[0] + k, arr[i] - k);
                    minDiff = Math.Min(minDiff, max - min);
                }
            }
            return minDiff;

          
        }
    }
}
