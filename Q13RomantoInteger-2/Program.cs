using System;
using System.Collections.Generic;

namespace Q13RomantoInteger_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            int[] nums1 = { 0, 0, 0, 0 };
            int[] nums2 = { 1, -1, -1, 0 };//i=0,j=1,k=2
            int[] nums3 = { 0, 0, 0, -1, 1 };

        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {   // sulution 2 pointer
            // sort array(lowesr to highest) and lock one point and do two sum for the other two
            IList<IList<int>> result = new List<IList<int>>();
           
            Array.Sort(nums);
            int target = 0;//{-1,-1,0,1}

            for (int i = 0; i < nums.Length; i++)
            {
                if (i>0 && nums[i]==nums[i-1])// skip duplicates
                {
                    continue;
                }
                int j = i + 1;
                int k = nums.Length - 1;
                while (j<k)
                {
                    if (nums[i]+nums[j]+nums[k] < target)
                    {
                        j++;
                        while (j<k && nums[j]==nums[j-1])
                        {
                            j++;// skip duplicates
                        }
                    }
                    else if (nums[i]+nums[j]+nums[k]>target)
                    {
                        k--;
                        while (j<k&&nums[k]==nums[k+1])
                        {
                            k--;// skip duplicates
                        }
                    }
                    else
                    {
                        IList<int> res = new List<int>();
                        res.Add(nums[i]);
                        res.Add(nums[j]);
                        res.Add(nums[k]);
                        result.Add(res);
                        j++;
                        k--;
                        while (j<k&&nums[j]==nums[j-1])
                        {
                            j++;
                        }
                        while (j<k&&nums[k]==nums[k+1])
                        {
                            k--;
                        }
                    }

                }
            

            }


            return result;
        }

    }
}
