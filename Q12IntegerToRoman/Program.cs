using System;
using System.Text;

namespace Q12IntegerToRoman
{
    public class Romans
    {
        public int value;
        public string symbol;

        public Romans(string symbol, int value)
        {
            this.symbol = symbol;
            this.value = value;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //1 <= num <= 3999
            int num1 = 3;
            int num2 = 4;
            int num3 = 9;
            int num4 = 58;
            int num5 = 1994;

            Console.WriteLine(IntToRoman1(33));
            Console.ReadLine();
        }


        public static string IntToRoman(int num)
        {   //48
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            System.Text.StringBuilder str = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    str.Append(symbols[i]);
                    num -= values[i];//8
                }
            }

            return str.ToString();
        }

        /*
         * 3320  = 3000 +300 + 20 +0
         3320-3320!1000=3000  ==320
           320- 320!100 =300
            20-20!10=20
            0-0!1=0
         */




        public static string IntToRoman1(int num)
        {
            Romans[] romans = {
            new Romans("M",1000),
            new Romans("CM",900),
            new Romans("D",500),
            new Romans("CD",400),
            new Romans("C",100),
            new Romans("XC",90),
            new Romans("L",50),
            new Romans("XL",40),
            new Romans("X",10),
            new Romans("IX",9),
            new Romans("V",5),
            new Romans("IV",4),
            new Romans("I",1) };
            
            string result = "";
            foreach (var x in romans)
            {
                int number = num / x.value;// 3200/1000=3, if 320/1000=0
                if (number >0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        result += x.symbol;
                    }

                    num %= x.value;

                }
            }
            return result;
        }


       /* 
    public static string IntToRoman3(int num) 
        {
            
            int numLen = num.ToString().Length;
            int numPower= num.ToString().Length-1;
            for (int i = 0; i < numLen; i++)
            {   int res =(int)(num % (Math.Pow(10, numPower)));
                int number = num - res;
                Console.WriteLine(number);
                num = res;
                numPower--;
            }

            return "x";
        }
       */
    }
}

