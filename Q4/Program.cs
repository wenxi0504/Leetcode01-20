using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        { Solution S = new Solution();
            int i = 5/2;
            int[] nums1 = { 2,4,6,7,10 };
            int[] nums2 = { 1,3,5,8,9,11,12,13,14 };//
            Console.WriteLine(S.FindMedianSortedArrays2(nums1,nums2));
            Console.WriteLine(i);
            Console.ReadKey();


        }
        public class Solution
        { //Given two sorted arrays nums1 and nums2 of size m and n respectively,
          //return the median of the two sorted arrays.

            
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {

                int[] combined = nums1.Concat(nums2).ToArray();
                Array.Sort<int>(combined,delegate (int a, int b)
                {
                 return b - a; //Normal compare is a-b
                });
                int size = combined.Length;
                int mid = size / 2;
                double median = (size % 2 != 0) ? (double)combined[mid] : ((double)combined[mid] + (double)combined[mid - 1]) / 2;
                return median;

            }

            public double FindMedianSortedArrays2(int[]A, int[]B)
            {  // array A 的长度 和 array B 的长度;
                int lenA = A.Length, lenB = B.Length;
                //长度较小的array放在左边，因为要检索长度小的array
                if (lenA>lenB)
                {
                    return FindMedianSortedArrays2(B, A);
                }
                //组合array的长度,k为检索的指针,cutA为分界线数左边的个数
                //lA>RB ,lB>RA
                int len = lenA + lenB;
                int A_startK=0,A_endK = lenA;
                int cutA = 0, cutB = 0;
                while (A_startK <= A_endK)
                {
                    cutA = (A_endK + A_startK) / 2;//
                    cutB = (len + 1) / 2 - cutA;//
                    double lA = A[cutA - 1];//
                    double lB = B[cutB - 1];//
                    double rA = A[cutA];//
                    double rB = B[cutB];
                    if (lA>rB)
                    {
                        A_endK = cutA - 1;
                    }
                    else if (lB>rA)
                    {
                        A_startK = cutA + 1; 
                    }
                    else
                    {
                        if (len% 2 == 0)
                        {
                            
                            return (Math.Max(lA, lB) + Math.Min(rA, rB)) / 2;
                        }
                        else 
                        {
                            return Math.Max(lA, lB);
                        }
                    }

                }    
                return -1;


            }

        }
            
    }
}
