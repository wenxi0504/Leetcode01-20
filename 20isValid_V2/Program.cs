using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20isValid_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "()";
            string s1 = "[]";
            string s2 = "{}";
            string s3 = "()[]{}";
            string s4 = "(]";
            string s5 = "{[]}";
            string s6 = "([}}])";
            string s7 = "()))";

           // Console.WriteLine(s7 + IsValid(s7));
            //Console.WriteLine(s6 + IsValid(s6));
            Console.WriteLine(s5 + IsValid(s5));
            Console.WriteLine(s + IsValid(s));
            Console.WriteLine(s1 + IsValid(s1));
            Console.WriteLine(s2 + IsValid(s2));
            Console.WriteLine(s3 + IsValid(s3));
            Console.WriteLine(s4 + IsValid(s4));
        }

        public static bool IsValid(String s)
        {
            Dictionary<char, char> character = new Dictionary<char, char>();
            character.Add(')', '(');
            character.Add('}', '{');
            character.Add(']', '[');

            Stack<char> stack = new Stack<char>();

            foreach (var c in s.ToCharArray())
            {
                if (!character.ContainsKey(c))
                {  // get '(','{','['
                    stack.Push(c);
                }
                else
                {   // make sure open bracets must be before the cloesed bracets
                    if (stack.Count==0)
                    {
                        return false;
                    }
                    char lastest = stack.Pop();
                    if (lastest !=character[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;

        }
    };

}
    