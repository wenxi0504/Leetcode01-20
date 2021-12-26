using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Q3
{   /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    ///Example 1:
    ///Input: s = "abcabcbb"
    ///Output: 3
    ///Explanation: The answer is "abc", with the length of 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string s = "abcabcbb";
            string s1 = "pwwkew";
            Console.WriteLine(sol.LengthOfLongestSubstring(s));
            Console.WriteLine(sol.LengthOfLongestSubstring1(s1));
            Console.ReadKey();
        }
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {   // hashset store uniqe elments
                HashSet<char> c = new HashSet<char>(s);
                return c.Count();
            }

            public int LengthOfLongestSubstring1(string s)
            {
                int i = 0;//pointer i to check the string
                int j = 0;//pointer j to point the first uniq character
                int maxLength = 0;//max length of substring:i-j+1
                if (s == null || s.Length == 0)
                {
                    return 0;
                }
                else
                {
                    HashSet<Char> set = new HashSet<char>();
                    while (i<s.Length)
                    {
                        char c = s[i];    
                        while (set.Contains(c))
                        {
                            set.Remove(s[j]); 
                            j++;
                        }
                        set.Add(c);  
                        maxLength = Math.Max(maxLength, i - j + 1);
                        i++;
                    }
                   

                }



                return maxLength;
            }
        }

    }
}

   
