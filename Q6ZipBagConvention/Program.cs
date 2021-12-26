using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6ZipBagConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string result = sol.Convert(s, numRows);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }

    public class Solution
    {
        //Input: s = "PAYPALISHIRING", numRows = 3
        // Output: "PAHNAPLSIIGYIR"
       
        public string Convert(string s, int numRows)
        {
            char[] c = s.ToCharArray();//PAYPALISHIRING"
            string[] str= new string[numRows];
            int index = 0;
            while (index<c.Length)
            {
                for (int i = 0; i < numRows&& index <c.Length; i++)
                {
                    str[i]+=c[index++].ToString();
                    //str[0]=p
                    //str[1]=A
                    //str[2]=Y
                }

                // start with numrow-2, end with str[1]
                for (int j = numRows-2; j >=1 && index < c.Length; j--)
                {
                    str[j]+=c[index++].ToString();

                }
            
            }
             for (int k = 1; k < numRows; k++)
            {
                str[0] += str[k];
           }
           


            return str[0];

        }
    }
}


