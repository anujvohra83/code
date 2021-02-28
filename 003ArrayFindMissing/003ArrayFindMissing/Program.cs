using System;

namespace ArrayFindMissing
{
    class MainClass
    {
        /*
        You are given a list of n-1 integers and
         these integers are in the range of 1 to n.
        There are no duplicates in the list.
        One of the integers is missing in the list.
        Write an efficient code to find the missing integer.
        */

        public static void Main(string[] args)
        {

            int[] array01 = { 1, 2, 4, 5 };
            int missing = FingMissingNumber(array01, 5);
            Console.WriteLine(missing);

        }

        // Find missing number
        static int FingMissingNumber(int[] array01, int n)
        {
            int sumOfN = n * (n + 1) / 2;

            for (int i = 0; i < array01.Length; i++)
            {
                //Keep subtracing all the arrays elements one by one
                sumOfN = sumOfN - array01[i];
            }


            return sumOfN;
        }
    }


}

