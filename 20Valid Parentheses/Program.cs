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
            string s6= "([}}])";
            string s7 = "()))";

            Console.WriteLine(s7 + IsValid(s7));
            Console.WriteLine(s6 + IsValid(s6));
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
            //check if string contains open and close brancts
            if (s.Contains(")") && !s.Contains("(") || s.Contains("}") && !s.Contains("{") || s.Contains("]") && !s.Contains("["))
            {
                return false;
            }

            int count = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0,count5=0;
            // check the numbers of open brancts are equal to close brancts
            foreach (var item in s)
            {
                if (item=='(')
                {
                    
                    count++;
                }
                else if (item == ')')
                {
                    
                        count1++;
                }
                else if (item == '{')
                {
                   
                    count2++;
                }
                else if (item=='}')
                {
                    
                    count3++;
                }
                else if(item =='[')
                {
                    
                    count4++;
                }
                else if (item ==']')
                {
                    count5++;
                }

            }

            if (count != count1 || count2!=count3|| count4!=count5)
            {
                return false;
            }

            // Instantiate a stack 
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                
                if (s.Substring(i, 1) == "{" || s.Substring(i, 1) == "(" || s.Substring(i, 1) == "[")
                {  // push charecters into the stack
                    stack.Push(s.Substring(i, 1));
                }
                else if (s.Substring(i, 1) == "}"  && stack.Count!=0 && stack.Peek().Equals("{"))
	            {
                    stack.Pop();
	            }
                else if (s.Substring(i,1)=="]" &&stack.Count!=0 && stack.Peek().Equals("["))
                { 
                    stack.Pop();
                }
                else if (s.Substring(i,1)==")" &&stack.Count!=0 && stack.Peek().Equals("("))
                { 
                    stack.Pop();
                }
			}

            return stack.Count==0;
        }


    }
}
