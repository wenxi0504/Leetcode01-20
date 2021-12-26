using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Q13RomantoInteger
{
    class Program
    {  //1 <= s.length <= 15
        //It is guaranteed that s is a valid roman numeral in the range [1, 3999].
        static void Main(string[] args)
        {
            string s = "III";
            string s1 = "IV";
            string s2 = "IX";
            string s3 = "LVIII";
            string s4 = "MCMXCIV";


            // Console.WriteLine(RomanToInt(s));//3
            // Console.WriteLine(RomanToInt1(s1));//4
            // Console.WriteLine(RomanToInt1(s2));//9
            // Console.WriteLine(RomanToInt1(s3));//58
            Console.WriteLine(RomanToInt1(s4));//1994

            Console.ReadLine();
        }
        #region switch method
        public static int RomanToInt(string s)
        {
            //string[] symbols = { "M",  "CM", "D", "CD", "C", "XC","L", "XL", "X", "IX", "V", "IV", "I" };
            // int[] values =      { 1000, 900, 500, 400,  100,  90,  50,  40,  10,   9,    5,    4,   1 };
            int j = 0;
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    j = i + 1;
                }
                switch (s.ElementAt(i))
                {
                    case 'M':
                        sum += 1000;
                        break;
                    case 'C':
                        if (s.ElementAt(j) == 'M')
                        {
                            sum += 900;
                            i++;
                            break;
                        }
                        else if (s.ElementAt(j) == 'D')
                        {
                            sum += 400;
                            i++;
                            break;
                        }
                        else
                        {
                            sum += 100;
                            break;
                        }
                    case 'D':
                        sum += 500;
                        break;
                    case 'X':
                        if (s.ElementAt(j) == 'C')
                        {
                            sum += 90;
                            i++;
                            break;
                        }
                        else if (s.ElementAt(j) == 'L')
                        {
                            sum += 40;
                            i++;
                            break;
                        }
                        else
                        {
                            sum += 10;
                            break;
                        }
                    case 'V':
                        sum += 5;
                        break;
                    case 'L':
                        sum += 50;
                        break;
                    case 'I':
                        if (s.ElementAt(j) == 'X')
                        {
                            sum += 9;
                            i++;
                            break;
                        }
                        else if (s.ElementAt(j) == 'V')
                        {
                            sum += 4;
                            i++;
                            break;
                        }
                        else
                        {
                            sum += 1;
                            break;
                        }
                    default:
                        break;
                }
            }
            return sum;

        }
        #endregion
        #region Dictionary method
        public static int RomanToInt1(string s)
        {//string[] symbols = { "M",  "CM", "D", "CD", "C", "XC","L", "XL", "X", "IX", "V", "IV", "I" };
         // int[] values =      { 1000, 900, 500, 400,  100,  90,  50,  40,  10,   9,    5,    4,   1 };

            int res = 0;
            int j = 0;
            Dictionary<char, int> romanToInt = new Dictionary<char, int>();
            romanToInt.Add('I', 1);
            romanToInt.Add('V', 5);
            romanToInt.Add('X', 10);
            romanToInt.Add('L', 50);
            romanToInt.Add('C', 100);
            romanToInt.Add('D', 500);
            romanToInt.Add('M', 1000);

            //"IV"=4
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanToInt[s[i]] < romanToInt[s[i + 1]])
                {
                    res -= romanToInt[s[i]];//-1
                }
                else
                {
                    res += romanToInt[s[i]];//5
                }
            }
            return res;
        }
        #endregion

     

    } 
}
