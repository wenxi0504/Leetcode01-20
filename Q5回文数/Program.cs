using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Longest Palindromic Substring
namespace Q5回文数
{
    class Program
    {
        static void Main(string[] args)
        {

            string s2 = "fabbadafeabcbaz";
            string  s = "fracecar";
            string s1 = "bab";
            string s3 = "babad";
            Solution sol = new Solution();
             string result=sol.LongestPalindrome(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    public class Solution
    {
        int start = 0;
        int len = 0;
        public string LongestPalindrome(string s)
        {
            //i是中位数
            for (int i = 0; i < s.Length; i++)
            { 
               int oddSubstringLen = GetPalindromelength(s,i,i);
               int evenSubstringLen = GetPalindromelength(s, i, i + 1);
               int maxSubrting = Math.Max(oddSubstringLen, evenSubstringLen);
                if (maxSubrting>len)
                {
                    len = maxSubrting;
                    start = i - (maxSubrting - 1) / 2;// bab 1-(3-1)/2=0; //jbaabc 2-(4-1)/2

                }
            }
            return s.Substring(start, len);
        }

        // this method to get all palindrome substrings 
        //"racecar","abba"
        public int GetPalindromelength(string s, int leftIdx, int rightIdx)
        {
         
            if (s==null || leftIdx>rightIdx)
            {
                return -1;

            }
            //bab(l) racecar  e=0,c=-1,c=1 l=1; e=1,c=0,c=1,b=-1,b=2,l=2,e=3,.....
            while (leftIdx >=0 && rightIdx < s.Length && s.ElementAt(leftIdx)==s.ElementAt(rightIdx))
            {
                leftIdx--; 
                rightIdx++; 

            }
            return rightIdx-leftIdx-1;//
        
        }
    }
}
