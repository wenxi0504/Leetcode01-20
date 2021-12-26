using System;

namespace Q14Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] strs = {"flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string str="";
            for (int i = 0; i < strs[0].Length; i++)//0<5
            {
                foreach (var x in strs)
                {
                    if (i> x.Length-1)
                    {
                        return str;
                    }
                    else if (strs[0][i]!=x[i])
                    {
                        return str;
                    }
                }
                str += strs[0][i];

            }

            return str;
        }
    }
}
