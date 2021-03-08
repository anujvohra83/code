using System;
using System.Collections.Generic;

namespace ArrayFindTwoSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 9, 10 };


            Console.Write("Array01: ");
            Print(array01);

            Console.WriteLine(Environment.NewLine);

            Console.Write("Enter a number : ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] result = FindSum(array01, k);

            Console.Write($"The 2 numbers which adds to {k} are : ");
            Print(result);
            Console.Read();

        }

        public static void Print(int[] array01)
        {
            for (int i = 0; i < array01.Length; i++)
            {
                Console.Write(array01[i] + " ");
            }
        }

        public static int[] FindSum(int[] arr, int k)
        {
            HashSet<int> hashSet = new HashSet<int>();
            int[] result = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                if(hashSet.Contains(k-arr[i]))
                {
                    result[0] = arr[i];
                    result[1] = k - arr[i];
                    break;
                }
                hashSet.Add(arr[i]);
            }

            // return the elements in the array whose sum is equal to the value
            //passed as parameter
            return result;
        }
    }
}
