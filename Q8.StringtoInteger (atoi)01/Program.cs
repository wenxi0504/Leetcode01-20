using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8.StringtoInteger__atoi_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "42";
            string s1 = "     -42";
            string s2 = "4193 with words";
            string s3 = "words and 987";
            string s4 = "-91283472332";

            Console.WriteLine(MyAtoi(s1));
            //Console.WriteLine(MyAtoi(s2));
            //Console.WriteLine(MyAtoi(s3));
            //Console.WriteLine(MyAtoi(s));
            Console.WriteLine(MyAtoi(s4));
            Console.ReadLine();
        }

        public static int MyAtoi(string s)
        {
            string str= s.Trim();
            if (str==null || str.Length==0)
            {
                return 0;
            }

            int sign = 1;
            int idx = 0;
            char c = str.ElementAt(0);
            if (c=='+')
            {
                sign = 1;
                idx++;

            }
            else if (c=='-')
            {
                sign = -1;
                idx++;
            }

            long sum = 0;
            for (int i = idx; i < str.Length; i++)
            {
                if (!Char.IsDigit(str.ElementAt(i)))
                {
                return (int)sum * sign;
                }
              sum = sum * 10 + str.ElementAt(i) - '0';
                if (sign ==1 && sum> Int32.MaxValue)
                {
                    return Int32.MaxValue;
                }

                if (sign==-1&& sum<Int32.MinValue)
                {
                    return Int32.MinValue;
                }
            }
            return (int)sum*sign;
        }
        }
}
