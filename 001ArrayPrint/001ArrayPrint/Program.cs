using System;

namespace ArrayPrint
{
    class MainClass
    {
        //Print array

        public static void Main(string[] args)
        {
            ArrayOperations arrOps = new ArrayOperations();

            int[] array01 = new int[5];

            //Get input from user
            for (int i = 0; i < array01.Length; i++)
            {
                Console.WriteLine($"Enter Array element {i}: ");
                array01[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(Environment.NewLine);

            //Printing an array:
            Console.WriteLine($"Array elements: ");
            arrOps.Print(array01);
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
    }
}
