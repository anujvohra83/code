using System;

namespace ArraySort012
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 2, 2, 0, 1, 0, 1 };
            sort012(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
        public static void sort012(int[] a)
        {

            int low = 0;
            int mid = 0;
            int t;
            int high = a.Length - 1;

            while (mid <= high)
            {
                if (a[mid] == 0)
                {

                    t = a[mid];
                    a[mid] = a[low];
                    a[low] = t;



                    mid++;
                    low++;
                    continue;
                }
                if (a[mid] == 1)
                {
                    mid++;
                    continue;
                }
                if (a[mid] == 2)
                {

                    t = a[mid];
                    a[mid] = a[high];
                    a[high] = t;


                    high--;
                    continue;
                }

            }

        }



    }
}
