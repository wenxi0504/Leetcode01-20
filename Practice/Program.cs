using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "8@com 2";
           
            Console.WriteLine(GetNum(s));
            Console.ReadKey();
        }

        public static int CalculateLength (string s)
        {  


            return s.Length;
        }

        public static int GetNum(string s)

        {
            int intVal=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) == ' ')
                {
                    intVal = (int)Char.GetNumericValue(s.ElementAt(i + 1));
                }

            }
            return intVal;

            
        }
    }


}
