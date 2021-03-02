using System;

namespace ArrayRotateCyclically
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1, 22, 3, 4, 15, 10};
            Console.Write("Original Array: ");
            foreach (var item in array01)
            {
                Console.Write(item + " ");
            }
            int last = array01[array01.Length - 1];
            
            for (int i = array01.Length-1; i > 0; i--)
            {
                array01[i] = array01[i - 1];
            }
            array01[0] = last;

            Console.WriteLine(Environment.NewLine);
            Console.Write("Cyclically Rotated Array by one: ");
            foreach (var item in array01)
            {
                Console.Write(item + " ");
            }
        }
    }
}
