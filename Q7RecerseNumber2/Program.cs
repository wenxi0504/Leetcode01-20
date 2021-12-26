using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7RecerseNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -123;
            int x4 = 1534236469;
            Console.WriteLine(reverse(x4));
            Console.ReadLine();
        }

        public static int reverse(int x)
        {
            
            long n = 0;
            while (x != 0)
            {
                n = n * 10 + x % 10;
                x = x / 10;
            }
            return (int)n == n ? (int)n : 0;
        }
    }
}
