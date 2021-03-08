using System;

namespace ArrayNumberOfOccurences
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 9, 10 };


            Console.Write("Array01: ");
            for (int i = 0; i < array01.Length; i++)
            {
                Console.Write(array01[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write("Search number of occurences for : ");
            int k = Convert.ToInt32(Console.ReadLine());

            int index= BinarySearch(array01, k);

            int totalOccurences = 0;

            //If atleast one element found
            if (index != -1)
            {
                //Get the left count
                int left = index - 1;
                int leftCount = 0;
                while (left > -1 && array01[left] == k)
                {
                    leftCount++;
                    left--;
                }

                //Get the right count
                int right = index + 1;
                int rightCount = 0;
                while (right < array01.Length && array01[right] == k)
                {
                    rightCount++;
                    right++;
                }


                totalOccurences = leftCount + 1 + rightCount;
            }

            Console.Write($"Total number of occurences for : {k} in the " +
                $"array is {totalOccurences}" );
            Console.Read();

        }
        static int BinarySearch(int[] arr, int k)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid;

            while (start <= end)
            {
                mid = start + (end- start) / 2;

                if (k == arr[mid])
                {
                    return mid;
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
            return -1;
        }
    }
}
