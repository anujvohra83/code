using System;
using System.Collections.Generic;

namespace ArrayFindAllDuplicates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 14, 7, 14, 6, 1, 11, 3, 16, 16, 8, 7, 4, 11, 15, 17, 6, 1, 13 };
            //{ 1, 3, 4, 3, 5, 4, 100, 100 };

            Console.Write("Input Array: ");
            Print(arr);

            List<int> duplicates = FindDuplicates(arr);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Duplicates: ");
            foreach (var item in duplicates)
            {
                Console.Write(item + " ");
            }

        }
        static void Print(int[] array01)
        {
            for (int i = 0; i < array01.Length; i++)
            {
                Console.Write(array01[i] + " ");
            }
        }
        static List<int> FindDuplicates(int[] arr)
        {
            Dictionary<int,int> set = new Dictionary<int,int>();
            List<int> duplicates = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(set.ContainsKey(arr[i]))
                {
                    set[arr[i]] = set[arr[i]] + 1;
                }
                else
                {
                    set.Add(arr[i], 1);
                }
            }

            foreach (var item in set)
            {
                if(item.Value > 1)
                {
                    duplicates.Add(item.Key);
                }
            }

            return duplicates;

        }
    }
}
