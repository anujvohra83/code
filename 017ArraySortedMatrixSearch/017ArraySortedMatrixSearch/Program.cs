using System;

namespace ArraySortedMatrixSearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[,] {
                              {10, 11, 12, 13},
                              {14, 15, 16, 17},
                              {27, 29, 30, 31},
                              {32, 33, 39, 50}
                            };

            
            Console.Write("Input Array: ");
            Console.WriteLine(Environment.NewLine);
            Print(matrix);

            Console.Write("Enter the number to search: ");
            // Element to search in the sorted matrix
            int target = Convert.ToInt32(Console.ReadLine());

            Boolean result = SearchElement(matrix, target);
            Console.WriteLine(Environment.NewLine);
            if(result)
                Console.WriteLine($"Element {target} exists in the array matrix.");
            else
                Console.WriteLine($"Element {target} doesn't exists in the array matrix.");


        }
        static void Print(int[,] arr)
        {
            // Display the array elements.
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        static bool SearchElement(int[,] matrix, int target)
        {
            int numberOfRows = matrix.GetLength(0);
            int numberOfColumns = matrix.GetLength(1);
            int min = 0;
            int max = numberOfRows * numberOfColumns - 1;

            while (min <= max)
            {
                int middle = (min + max) / 2;
                int row = middle / numberOfColumns;
                int col = middle % numberOfColumns;
                if (target < matrix[row,col])
                {
                    max = middle - 1;
                }
                else if (target > matrix[row,col])
                {
                    min = middle + 1;
                }
                else
                {
                    return true;
                }

            }
            return false;

        }
    }
}
