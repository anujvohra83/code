using System;

namespace Array_FindMaxMin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayOperations arrOps = new ArrayOperations();

            int[] array01 = new int[5];

            //Get input from user
            for (int i = 0; i < array01.Length; i++)
            {
                Console.WriteLine($" Enter Array element {i}: ");
                array01[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(Environment.NewLine);

            //Printing an array:
            Console.WriteLine($"Array elements: ");
            arrOps.Print(array01);

            int max = arrOps.FindMaximum(array01);
            Console.WriteLine($"Maximum element in the array is: {max}");

            int min = arrOps.FindMinimum(array01);
            Console.WriteLine($"Minimum element in the array is: {min}");

        }
    }
    public class ArrayOperations
    {
        public void Print(int[] array)
        {
            //Print array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public int FindMaximum(int[] array)
        {
            int maximum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }

            }
            return maximum;
        }
        public int FindMinimum(int[] array)
        {
            int minimum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }

            }
            return minimum;
        }
    }
}
