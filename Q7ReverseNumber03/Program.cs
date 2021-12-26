using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7ReverseNumber03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -123;
            int x1 = 123;
            Console.WriteLine(Reverse(x1));
            Console.WriteLine(Reverse(x));
            Console.ReadLine();
        }

        public static int Reverse(int x)
        { int len = x.ToString().Length;
            int[] array = new int[x.ToString().Length];
            char[] number = new char[x.ToString().Length];
            
            for (int i = 0; i < len; i++)
            {
                array[i]=x%10;
                x = x / 10;
                

            }
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res += array[i] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
            }

            Console.WriteLine(res);
            return 0;
        }

   
    }
}
