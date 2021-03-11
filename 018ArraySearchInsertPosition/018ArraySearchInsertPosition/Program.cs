using System;

namespace ArraySearchInsertPosition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 5, 6 };

            // Example 1
            Console.WriteLine("Index to Insert " + "\"5\" is " +
                "" + insertPosition(arr, 5));

            // Example 2
            Console.WriteLine("Index to Insert " + "\"3\" is " +
                "" + insertPosition(arr, 3));

            // Example 3
            Console.WriteLine("Index to Insert " + "\"7\" is " +
                "" + insertPosition(arr, 7));

            // Example 4
            Console.WriteLine("Index to Insert " + "\"4\" is " +
                "" + insertPosition(arr, 4));

            Console.ReadLine();
        }
        public static int insertPosition(int[] arr, int k)
        {
            // write your code here

            int start = 0;
            int end = arr.Length - 1;
            int mid = -1;
            Boolean found = false;
            while (start <= end)
            {
                mid = (end + start) / 2;

                if (k == arr[mid])
                {
                    found = true;
                    break;
                }
                else if (k < arr[mid])
                {
                    end = mid - 1;
                }
                else if (k > arr[mid])
                {
                    start = mid + 1;
                }

            }
            if (found)
            {
                return mid;
            }
            else
            {
                return start;
            }

        }

    }
}
