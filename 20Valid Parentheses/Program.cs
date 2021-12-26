using System;
using System.Collections;

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
        {  // using stack mathod

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
            // check if the length of string is odd or even
            if (s.Length %2 !=0 )
	        {
                return false;
	        }
            // Instantiate a stack 
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
			{
                if (s.Substring(i,1) =="{" || s.Substring(i,1)=="(" || s.Substring(i,1)=="[")
                {  // push charecters into the stack
                    stack.Push(s.Substring(i, 1));
                }
                else if (s.Substring(i,1)=="}" && stack.Count!=0 && stack.Peek().Equals("{"))
	            {
                    stack.Pop();
	            }
                else if (s.Substring(i,1)=="]" && stack.Count!=0 && stack.Peek().Equals("["))
                { 
                    stack.Pop();
                }
                else if (s.Substring(i,1)==")" && stack.Count!=0 && stack.Peek().Equals("("))
                { 
                    stack.Pop();
                }
			}

            return stack.Count==0;
        }


    }
}
