using System;
using System.Collections.Generic;

namespace ArrayGroupAnagrams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] arr =
                {
                   "cat",
                   "dog",
                   "tac",
                   "god",
                   "act",
                   "tom marvolo riddle ",
                   "abc",
                   "def",
                   "cab",
                   "fed",
                   "clint eastwood ",
                   "i am lord voldemort",
                   "elvis",
                   "old west action",
                   "lives"
                };

            Console.Write("Input: ");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);

            Console.Write("Group anagrams: ");
            String anagram= GroupAnagrams(arr);

            Console.WriteLine(anagram);
            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();


        }
        public static String GroupAnagrams(String[] arr)
        {
            Dictionary < string, List<string>> dict = new Dictionary<string, List<String>>();

            for (int i = 0; i < arr.Length; i++)
            {
                char[] charArray = arr[i].ToCharArray();
                Array.Sort(charArray);
                string sortedCharKey = string.Join("", charArray);


                if (dict.ContainsKey(sortedCharKey))
                {
                    dict[sortedCharKey].Add(arr[i]);
                }
                else
                {
                    List<string> wordValues = new List<string>();
                    wordValues.Add(arr[i]);
                    dict.Add(sortedCharKey, wordValues);
                }
            }

            String anagrams = String.Empty;
            foreach (var key in dict.Keys)
            {
                List<string> values = dict[key];
                string anagramSet= String.Empty;
                if (values.Count > 1)
                {
                    anagramSet = string.Join(",", values.ToArray());
                    
                }
                else
                {
                    anagramSet += values;
                }
                
                anagramSet= string.Concat("[", anagramSet, "]");
                anagrams += anagramSet;
            }
            return anagrams;
        }
        
    }
}
