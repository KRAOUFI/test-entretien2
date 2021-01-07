using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestAlgo
    {

        /// <summary>
        /// grouper les anagrammes 
        /// 10 min
        /// </summary>
        public static void RemoveDuplicate()
        {
            Console.WriteLine("RemoveDuplicate start");
            List<List<int>> datas = new List<List<int>>()
            {
                new List<int>() { 1,2,3,4,5,6,7,8,9},
                new List<int>() { 6,10,11,8,13,14,15,23},
                new List<int>() { 6,23,7,8},
                new List<int>() { 2,50,100,88},
            };
            
            
            
        }
        
        public static void GroupAnagram()
        {
            Console.WriteLine("GroupAnagram start");
            string[] input = { "reza","eat", "tea", "tan", "ate", "nate", "bat", "bta", "azer" };

            List<string> anagram = new List<string>();

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i != j)
                    {
                        if (IsAnagram(input[j], input[i]))
                        {
                            anagram.Add(input[j] + "-" + input[i]);
                        }
                    }
                    
                }               
                
            }

            Console.WriteLine(anagram.ToString());
        }

        private static bool IsAnagram(string text1, string text2)
        {
            var tabText1 = text1.ToCharArray();
            var tabText2 = text2.ToCharArray();

            if(tabText1.Length == tabText2.Length)
            {
                for (int i = 0; i < tabText1.Length; i++)
                {
                    if (!text2.Contains(tabText1[i]))
                    {
                        return false;
                    }                    
                }

            } else
            {
                return false;
            }
            return true;
        }

       


    }
}
