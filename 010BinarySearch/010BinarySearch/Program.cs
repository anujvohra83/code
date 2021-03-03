using System;

namespace BinarySearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1,2,3,4,5,6,7,8,9,10 };
            

            Console.Write("Array01: ");
            for (int i = 0; i < array01.Length; i++)
            {
                Console.Write(array01[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write("Enter a number to search in the given array " +
                "using binary search: ");
            int k = Convert.ToInt32(Console.ReadLine());

            BinarySearch(array01, k);
        }

        static void BinarySearch(int[] arr, int k)
        {
            bool isPresent = false;

            int start = 0;
            int end = arr.Length - 1;
            int mid;

            while(start <= end)
            {
                mid = (start + end) / 2;

                if (k == arr[mid])
                {
                    isPresent = true;
                    break;
                }
                else if (k < arr[mid])
                {
                    end = mid-1;
                }
                else if (k > arr[mid])
                {
                    start = mid+1;
                }
                
            }
            

            if(isPresent)
            {
                Console.Write($"The number {k} is present in the given array");
            }
            else
            {
                Console.Write($"The number {k} is NOT present in the given array");
            }
            
        }
    }
}
