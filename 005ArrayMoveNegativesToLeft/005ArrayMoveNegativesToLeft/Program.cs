using System;

namespace ArrayMoveNegativesToLeft
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, -13, -6, 0, 8, 9, -8, 90 };
            NegativeToLeft(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");

            }

        }
        public static void NegativeToLeft(int[] arr)
        {
            int t; int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;

                    j++;

                }
            }

        }

    }
}

