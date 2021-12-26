using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            int x1 = -123;
            int x2 = 120;
            int x3 = 0;
            int x4 = 1534236469;
           // Console.WriteLine(Reverse(x));
           // Console.WriteLine(Reverse(x1));
          // Console.WriteLine(Reverse(x2));
          // Console.WriteLine(Reverse(x3));
            Console.WriteLine(Reverse(x4));

            Console.ReadLine();
        }

        /*Input: x = 123
          Output: 321
          Input: x = -123
          Output: -321
          Input: x = 120
          Output: 21
          Input: x = 0
          Output: 0
         */
        public static int Reverse(int x)
        {
            
            int rev=0;
            int length = x.ToString().Count();
            int len = x.ToString().Count();
            if (x<0)
            {
                length--;
                for (int i = 0; i < len-1; i++)
                {   
                    int res = x % 10;//3
                    x = x / 10;
                    rev += (int)(res * Math.Pow(10, length - 1));
                    length--;
                }
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    int res = x % 10;//3
                    x = x / 10;
                    rev += (int)(res * Math.Pow(10, length - 1));
                    length--;
                }
            }
            
            return rev ;
        }
    }
}
