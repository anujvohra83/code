using System;
using System.Collections.Generic;

namespace ArrayUnionIntersection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array01 = { 2, 90, 4, 4, 6, 8, 9 };
            int[] array02 = { 3, 11, 4, 5, 6, 7 };

            Console.Write("Array01: ");
            for (int i = 0; i <= array01.Length-1; i++)
            {
                Console.Write(array01[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);
            Console.Write("Array02: ");
            for (int i = 0; i <= array02.Length - 1; i++)
            {
                Console.Write(array02[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write("Intersection: ");
            Intersection(array01, array02);

            Console.WriteLine(Environment.NewLine);
            Console.Write("Union: ");
            Union(array01, array02);
            Console.ReadLine();

        }

        static void Intersection(int[] array01, int[] array02)
        {
            int m = array01.Length;
            int n = array02.Length;
            int i = 0;
            int j = 0;

            Array.Sort(array01);
            Array.Sort(array02);

            HashSet<int> set = new HashSet<int>();

           
            while(i<m && j<n)
            {
                if (array01[i] < array02[j])
                { 
                    i++;
                }
                else if (array02[j] < array01[i])
                {
                    j++;
                }
                else
                {
                    if(!set.Contains(array02[j]))
                    {
                        set.Add(array02[j]);
                    }
                    
                    i++;
                    j++;
                   
                }
                
            }
           
            foreach (int a in set)
            {
                Console.Write(a + " ");
            }

        }

        static void Union(int[] array01, int[] array02)
        {
            int m = array01.Length;
            int n = array02.Length;

            Array.Sort(array01);
            Array.Sort(array02);

            HashSet<int> unionSet = new HashSet<int>();

            for (int i = 0; i <= m-1; i++)
            {
                if (!unionSet.Contains(array01[i]))
                {
                    unionSet.Add(array01[i]);
                }
            }

            for (int j = 0; j <= n-1; j++)
            {
                if (!unionSet.Contains(array02[j]))
                {
                    unionSet.Add(array02[j]);
                }
            }
            foreach (int a in unionSet)
            {
                Console.Write(a + " ");
            }

        }
    }
}
