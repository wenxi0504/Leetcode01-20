using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q88.StringtoInteger__atoi_
{
    class Program
    {
        /*Input: s = "42"
          Output: 42
          Input: s = "   -42"
          Output: -42
          Input: s = "4193 with words"
          Output: 4193
          Input: s = "words and 987"
          Output: 0
          Input: s = "-91283472332"
          Output: -2147483648
         */

        static void Main(string[] args)
        {
            string s = "42";
            string s1 = "     -42";
            string s2 = "4193 with words";
            string s3 = "words and 987";
          
            Console.WriteLine(MyAtoi(s1));
            Console.WriteLine(MyAtoi(s2));
            Console.WriteLine(MyAtoi(s3));
            Console.WriteLine(MyAtoi(s));
            Console.ReadLine();

        }
        public static int MyAtoi(string s)
        {

            string str = s.Replace(" ","");//remove all white space
            Console.WriteLine(str);
            int i = 0;//index
            int sign = 1;
            int sum = 0;
            int num = str.ElementAt(i) - '0'; ;// convert the value of char to int
           
            // check if the string is null or empty string
            if (str==null || str.Length==0)
            {
                return 0;
            }

            //check the if the value of index of 0 (the value of the first element) is "-" or "+"
            if (str.ElementAt(0)=='-' || str.ElementAt(0) == '+')
            {
         
                i++; // go to the next element
                num = str.ElementAt(i) - '0';
                //Console.WriteLine(num);
            }

            // check if the element is not digital number, then return 0
            if (num < 0 || num > 10)
            {
              
                return 0;
            }
            
            // while loop to get the digital number in the string and stop if the element is not digital number anymore
            while (i<str.Length)
            {
                num = str.ElementAt(i) - '0';
               // Console.WriteLine(str.ElementAt(i));
                    if (num >= 0 && num < 10) //
                    {

                        sum = sum * 10 + num;

                    }

                i++;
            }
            
            if (str.ElementAt(0)=='-')
            {
                sum = -sign * sum;
            }
            return sum;

        }
    }
}
