using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Q15._3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            int[] nums1 = { 0, 0, 0, 0 };
            int[] nums2 = { 1, -1, -1, 0 };//i=0,j=1,k=2
            int[] nums3 = { 0, 0, 0, -1, 1 };
            int[] nums4 = { -1, 0, 1, 0 };
            //-1,0,1  -1,2,-1  -1,-4
            //0,1,2    0,-1,-4
            //1,2,-1   1,-4
            //2,-1,-4
            //-1,-4

             foreach (var item in ThreeSum(nums4))
             {
                foreach (var x in item)
                {
                    Console.Write(x);
                }
                Console.WriteLine("");
             }
            
            //Console.WriteLine(ThreeSum(nums).ToArray());
                
            
           
            
        }

        //Given an integer array nums, return all the triplets [nums[i], nums[j],
        //nums[k]] such that i != j, i != k, and j != k,
        //and nums[i] + nums[j] + nums[k] == 0.
        // int[] nums = { -1, 0, 1, 2, -1, -4 };
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> final = new List<IList<int>>();
            for ( int i = 0;  i < nums.Length;  i++)
            {
                int j = i + 1;
                int k= i + 2;
                //int x = 1;
                while (k< nums.Length)
                {
                    if (i != j && j != k && i != k && j < nums.Length)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (sum == 0)
                        { //[0,0,0,0]
                           IList<int> res = new List<int>();
                           res.Add(nums[i]);
                           res.Add(nums[j]);
                           res.Add(nums[k]);
                           if (notDuplicate(final,res))
                                final.Add(res);
        
                                             
                        }
                       
                        j++;
                        k++;
                    }
                }
                

            }
            return final; 
        }
        
        public static bool notDuplicate(IList<IList<int>> a, IList<int> b)
        {
            for (int j = 0; j < a.Count(); j++)
            {
                //Console.WriteLine(a[j].SequenceEqual(b));
                if (a[j].SequenceEqual(b))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
