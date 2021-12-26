using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5Vince
{
    class Program
    {
        static int no_of_chars = 256;
        static void Main(string[] args)
        {
            string s = "babfcdea";
            List<Char> loopChar = findDuplicates(s);
            List<string> sol = new List<string>();
            foreach (Char c in loopChar)
            {
                int start = s.IndexOf(c);
                int end = s.IndexOf(c, start + 1)+1;
                end = (end >= s.Length) ? --end : end;
                sol.Add(s.Substring(start, end));
            }

            printLongest(sol);

        }

        public static void printLongest(List<string> l)
        {
            int longest = 0;
            int x = 0;
            int res = 0;
            foreach (string s in l)
            {
                int z = s.Length;
                if (z > longest)
                {
                    longest = z;
                    res = x;
                }
                x++;
            }

            Console.WriteLine(l[res]);
            Console.ReadLine();

        }

        public static List<Char> findDuplicates(string s)
        {
            List<Char> meh = new List<Char>();
            int[] count = new int[no_of_chars];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }

            for (int i = 0; i < no_of_chars; i++)
            {
                if (count[i] > 1)
                    meh.Add((Char)i);
            }

            return meh;
        }

    }
}
