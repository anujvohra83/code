using System;

namespace ArrayRorateByK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 1, 22, 3, 4, 15, 10 };
            Console.Write("Original Array: ");
            foreach (var item in array01)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write("Enter K (rotate by) :");
            int k = Convert.ToInt32(Console.ReadLine());
            int length = array01.Length;
            
            
            k = k % length;

            /*int last = array01[length - 1];

            for (int i = length - 1; i > 0; i--)
            {
                array01[i] = array01[i - 1];
            }
            array01[0] = last;

            */
            if(k!=length) // If k is equal to length, we don't have to rotate.
            {
                ReverseArray(0, length-k-1,array01);
                ReverseArray(length-k, length - 1, array01);
                ReverseArray(0, length - 1, array01);
            }
            

            Console.WriteLine(Environment.NewLine);
            Console.Write($"Cyclically Rotated Array by {k} is : ");
            foreach (var item in array01)
            {
                Console.Write(item + " ");
            }
        }
        static void ReverseArray(int left, int right, int[] arr)
        {
            int temp;
            while(left < right)
            {
                temp= arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            
        }
    }
}
