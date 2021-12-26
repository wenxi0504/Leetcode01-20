using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Q1 q = new Q1() ;
            
            int[] n = {2,7,11,15};
            int t = 9;
            foreach (var item in q.TwoSum(n, t))
            {
                Console.WriteLine(item);
            }
            foreach (var item in q.TwoSum1(n,t))
            {
                Console.WriteLine(item);
            }

            double i = 18/10;
            int j = Convert.ToInt32(i);
            Console.WriteLine( j);
            Console.ReadKey();
        }
    }
}
