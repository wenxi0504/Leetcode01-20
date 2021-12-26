using System;

namespace _2九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NineNineMultiplicationTable());
        }

        public static string NineNineMultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    //int result = i*j;
                    //Console.Write(i+"x"+j+"="+result.ToString()+"   ");
                   Console.Write("{0}*{1}={2}   ",j,i,j*i);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            return "";
           
        
        }


    }
}
