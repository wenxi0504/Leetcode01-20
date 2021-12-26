using System;
using System.Collections.Generic;
using System.Linq;

namespace _17LetterCombinationsofaPhone_Number
{ /*Given a string containing digits from 2-9 inclusive, 
   * return all possible letter combinations that the number could represent. 
   * Return the answer in any order.
   * A mapping of digit to letters (just like on the telephone buttons) is given below. 
   * Note that 1 does not map to any letters.
   * 0 <= digits.length <= 4
   * digits[i] is a digit in the range ['2', '9'].
   */
    class Program
    {
        private static List<string> res = new List<string>();
        static Dictionary<int, string> numConvertLetter = new Dictionary<int, string>()
            { { 0,""},
              { 1,""},
              { 2,"abc"},
              { 3,"def"},
              { 4,"ghi"},
              { 5,"jkl"},
              { 6,"mno"},
              { 7,"pqrs"},
              { 8,"tuv"},
              { 9,"wxyz"},
            };
        static void Main(string[] args)
        {
            string digits = "23"; //["ad","ae","af","bd","be","bf","cd","ce","cf"]
            string digits1 = "";
            string digits2 = "2";//["a","b","c"]
            Console.WriteLine("Hello World!");
        }

        public static IList<string> LetterCombinations(string digits)
        {  // stringbuild can be treated as undefined length arraylist
            
           
           // backtracking recurive  method 递归方法
            for (int i = 0; i < digits.Length; i++)//23
            {
                //int key= Convert.ToInt32(digits[i..]);//index 2 -> key 2
                //string value = numConvertLetter.ElementAt(key - 2).Value;//abc
                string value = numConvertLetter[i];//abc   def
                callBackTrack(i, value,digits);                            
                
            }
            return null ;
        }
         //2-abc
        public static IList<string> callBackTrack(int i, string curStr,string digits)
        {  if (curStr.Length == digits.Length)
            {
                res.Append(curStr);
            }
            else 
            {
                foreach (var c in numConvertLetter(i))
                {
                    callBackTrack(i + 1, curStr+c, digits);
                    

                }
            }
            return res;
        }
    }
}
