using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Longest Palindromic Substring
///  Input: s = "babad"
///  Output: "bab"
///  Note: "aba" is also a valid answer.
/// </summary>
namespace Q5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
           
           // int i = 0;//pointer i to check the string
           // int j = 0;//pointer j to point the first uniq character
           // int maxLength = 0;//max length of substring:i-j+1
           List<char> compareArr = new List<char>();
            List<char> cArr = new List<char>();
            int i = 0; int j = 0;
            if (s == null || s.Length == 0)
            {
                return "please input the valid string";
            }
            else
            {
               
                while (i<s.Length)
                    {
                    char c = s[i];
                    if (cArr.Contains(c))
                    {
                        cArr.Add(c);
                        if (compareArr.Count <= cArr.Count) 
                        {
                            compareArr.Clear();
                            compareArr.AddRange(cArr);
                            cArr.Remove(cArr[0]);
                           
                           
                        }
                    }
                    else
                    {
                        cArr.Add(c);
                       
                    }
                    i++;
                }
                 
            }

            var s1 = string.Concat(compareArr);
            return s1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Solution l = new Solution();
            string s1 = "babcfad";
            string s2 = "cbbd";
            string s3 = "a";
            string s4 = "ac";


           // Console.WriteLine(l.LongestPalindrome(s1));
            Console.WriteLine(l.LongestPalindrome(s2));
           // Console.WriteLine(l.LongestPalindrome(s3));
           // Console.WriteLine(l.LongestPalindrome(s4));
            Console.ReadKey();
           
           

        }
    }
}
