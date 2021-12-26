using System;

namespace _20Valid_Parentheses
{
    class Program
    {
        /* Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
         * determine if the input string is valid.
         * An input string is valid if:
         * Open brackets must be closed by the same type of brackets.
         * Open brackets must be closed in the correct order.
         * Input: s = "()"
         * Output: true
         * Input: s = "()[]{}"
           Output: true
           Input: s = "(]"
           Output: false
         * 
         */
        static void Main(string[] args)
        {  // using stack 

            string s = "()";
            string s1 = "[]";
            string s2 = "{}";
            string s3 = "()[]{}";
            string s4 = "(]";
            string s5 = "{[]}";


            Console.WriteLine(s5 + IsValid(s5));
            Console.WriteLine(s + IsValid(s));
            Console.WriteLine(s1 + IsValid(s1));
            Console.WriteLine(s2 + IsValid(s2));
            Console.WriteLine(s3 + IsValid(s3)); 
            Console.WriteLine(s4 + IsValid(s4));
        }

        public static bool IsValid(string s)
        { 




            return true;
        }


    }
}
