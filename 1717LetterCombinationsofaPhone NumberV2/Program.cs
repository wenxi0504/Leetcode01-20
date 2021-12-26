using System;
using System.Collections.Generic;
using System.Text;

namespace _1717LetterCombinationsofaPhone_NumberV2
{
    class Program
    {
        /*Given a string containing digits from 2-9 inclusive, 
        * return all possible letter combinations that the number could represent. 
        * Return the answer in any order.
        * A mapping of digit to letters (just like on the telephone buttons) is given below. 
        * Note that 1 does not map to any letters.
        * 0 <= digits.length <= 4
        * digits[i] is a digit in the range ['2', '9'].
        */
        public static string[] keyboard = new string[] {
        "","","abc","def","ghi","jkl","mno","pqrs","wxyz"
        };
        static void Main(string[] args)
        {
            string digits = "23"; //["ad","ae","af","bd","be","bf","cd","ce","cf"]
            string digits1 = "";
            string digits2 = "2";//["a","b","c"]
            List<string> showRes = new List<string>();
            showRes=letterCombinations(digits);
            foreach (var item in showRes)
            {
                Console.Write(item+","  );
                Console.WriteLine("---------------------");
            }
            
        }

        public static List<string> letterCombinations(string digits) 
        {
            List<string> result = new List<string>();
            //digits 0 and 1
            if (digits.Length==0)
            {
                return result;
            }
            //sb is the pathway between lettercombination and digits
            StringBuilder sb = new StringBuilder();
            dfs(digits,0,sb,result);

            return result;
        }

        public static void dfs(string digits, int index, StringBuilder sb, List<string> result)
        {
            string letters = "";
            if (index==digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }
            //Console.WriteLine(  keyboard[0]);
           
                int n=Convert.ToInt32(digits.Substring(index,1));
                letters = keyboard[n];// 2->abc
            
            
            for (int i = 0; i < letters.Length; i++)
            {
                char c = letters[i];
                sb.Append(c);
                    //递归方法 
                dfs(digits, index + 1, sb, result);
                    //ad,ad that has to remove the second one
                sb.Remove(sb.Length - 1, 1);
            }
            
            
            
        
        
        }





    }
}
