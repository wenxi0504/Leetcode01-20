using System;
using System.Collections.Generic;
using System.Collections;

namespace _18_4Sum
{
    /*Given an array nums of n integers, return an array of all the unique quadruplets 
     * [nums[a], nums[b], nums[c], nums[d]] such that:
     * 0 <= a, b, c, d < n
     * a, b, c, and d are distinct.
     * nums[a] + nums[b] + nums[c] + nums[d] == target
     * You may return the answer in any order.
     */
    // Input: nums = [1,0,-1,0,-2,2], target = 0
    //Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
    //Input: nums = [2,2,2,2,2], target = 8
    //Output: [[2,2,2,2]]
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            int target = 0;
            int[] nums1 = { 2, 2, 2, 2, 2 };
            int target1 = 8;

            Console.WriteLine("1."+FourSum(nums,target));
            Console.WriteLine("2." + FourSum(nums1, target1));

        }

        public static List<List<int>> FourSum(int[] nums, int target)
        {
            // A list to store the result
            List<List<int>> result = new List<List<int>>();
            //corner case: 
            if (nums.Length<4)
            {
                return (List<List<int>>)result;
            }
            //sort array ascending
            Array.Sort(nums);
            //lock first pointer
            for (int i = 0; i < nums.Length-3; i++)
            {
                // skip duplicates such as -1,-1,-1

                if (i>0 && nums[i]==nums[i-1])
                {
                    continue;
                }

                //lock the second pointer
                for (int j = i+1; j < nums.Length-2; j++)
                {
                    // skip duplicates such as -1,-1,-1

                    if (j > i+1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    // third pointer k and fourth pointer l
                    int k = j + 1;
                    int l = nums.Length - 1;
                    //start iteration
                    while (k < j)
                    { //get sum
                        int sum = nums[i] + nums[j] + nums[k] + nums[l];
                        // check the gap betweem sum and target(3 condition)
                        if (sum < target)
                        {
                            k++;// move key point to the right so close to the target
                            while (nums[k]==nums[k-1] && k<l)// skip duplicates
                            {
                                k++;
                            }
                        }
                        else if (sum >target)
                        {
                            l--;
                            while (nums[l] == nums[l+1] && k<l) 
                            {
                                l--;
                            }
                        }
                        else
                        {
                            IList<int> res = new List<int>();
                            res.Add(nums[i]);
                            res.Add(nums[j]);
                            res.Add(nums[k]);
                            res.Add(nums[l]);
                            result.Add((List<int>)res);
                            k++;
                            l--;
                            while (nums[k]==nums[k-1]&& k<l)
                            {
                                k++;
                            }
                            while (nums[l]==nums[l-1]&& l<l)
                            {
                                l--;
                            }

                        }
                    
                    }

                }
            }
            
            return result;

        }
    }
}
