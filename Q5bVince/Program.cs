using System;
using System.Collections.Generic;
using System.Text;

namespace Q5bVince
{
    class Program
    {
        static int no_of_chars = 256;
        static void Main(string[] args)
        {
            string s = "fabbadafeabcbaz";
            string s1 = "acbbcaed";
            solution(s);
        }

        public static void solution(string s)
        {
            List<track> h = findDuplicates(s);
            List<string> sol = new List<string>();

            foreach (track c in h)
            {
                for (int x = 0; x < c.indices.Count; x++)
                {
                    int start = s.IndexOf(c.dupeChar, c.indices[x]);
                    if (x + 1 != c.indices.Count)
                    {
                        int end = s.IndexOf(c.dupeChar, c.indices[x + 1]);
                        int len = end - start + 1;
                        string temps = s.Substring(start, len);

                        if (isPalindrome(temps) > 0)
                            sol.Add(temps);
                    }
                }
            }

            Console.WriteLine("IN: " + s);
            printLongest(sol);

        }

        public static int isPalindrome(string s)
        {

            int mid = s.Length / 2;
            int start = mid;
            if (s.Length % 2 == 1)
            {
                mid = (s.Length - 1) / 2;
                start = mid + 1;
            }
            string torev = s.Substring(start, s.Length - start);
            string og = s.Substring(0, mid);
            if (reverseString(og).Equals(torev))
            {
                return s.Length;
            }

            return 0;

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

            Console.WriteLine("OUT: " + l[res]);

        }

        public static string reverseString(string s)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);

            return new string(rev);
        }

        public static List<track> findDuplicates(string s)
        {
            List<Char> meh = new List<Char>();
            int[] count = new int[no_of_chars];
            List<track> h = new List<track>();

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }

            for (int i = 0; i < no_of_chars; i++)
            {
                if (count[i] > 1)
                {
                    char j = (Char)i;
                    h.Add(new track(j, findIndices(j, s)));
                }
            }
            return h;
        }
        public static List<int> findIndices(char c, string s)
        {
            List<int> ret = new List<int>();
            for (int x = 0; x < s.Length; x++)
            {
                if (c == (Char)s[x])
                {
                    ret.Add(x);
                }
            }
            return ret;
        }

    }

    public class track
    {
        public char dupeChar { get; set; }
        public List<int> indices { get; set; }

        public track(char a, List<int> b)
        {
            dupeChar = a;
            indices = b;
        }
    }
}
