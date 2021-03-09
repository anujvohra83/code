using System;

namespace ArrayMedian
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 2,100 };
            int[] array02 = { 4, 8, 11, 12, 20, 28 };
            int n1 = array01.Length;
            int n2 = array02.Length;

            Console.Write("Array01: ");
            Print(array01);
            Console.WriteLine(Environment.NewLine);
            Console.Write("Array02: ");
            Print(array02);

            double median = Median(array01, array02, n1, n2);

            Console.WriteLine(Environment.NewLine);
            Console.Write($"Median: {median} ");
            Console.ReadLine();

        }
        static void Print(int[] array01)
        {
            for (int i = 0; i < array01.Length; i++)
            {
                Console.Write(array01[i] + " ");
            }
        }
        static double Median(int[] array01, int[] array02, int n1, int n2)
        {
            int i = 0, j = 0, k = 0, y = 0;
            y = n1 + n2;
            int[] merg = new int[y];
            double median;

            //Merging both arrays 
            //Merge by compoaring elements and add the smaller first
            while (i < n1 && j < n2)
            {
                if (array01[i] <= array02[j])
                {
                    merg[k] = array01[i];
                    i++; k++;
                }
                else
                {
                    merg[k] = array02[j];
                    j++; k++;
                }
            }

            //Remaining elements from first array
            while (i < n1)
            {
                merg[k] = array01[i];
                i++; k++;
            }

            //Remaining elements from second array
            while (j < n2)
            {
                merg[k] = array02[j];
                j++; k++;
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write("Merged: ");
            Print(merg);

            //Calculate Median
            if (y % 2 != 0) //11
            {
                median = merg[(y +1) / 2];
            }
            else //10
            {
                median = (merg[(y - 1) / 2] + merg[y / 2]) / 2.0;
            }
            return median;
        }
    }
}
