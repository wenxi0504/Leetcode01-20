using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice
{
    class Q1
    {  /*Q1:Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.
          */
        
        /// <summary>
        /// Solution 1
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] newArray = new int[2];
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j= 1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j]==target)
                    {
                        newArray[0] =i;
                        newArray[1] = j;           
                    }
                }
            }
            return newArray;
        }

        //Solution 2 use indexOf 
        /*
         for( int i=0; i< nums.length; i++)
        {
         if (nums.indexOf(target-nums[i])>-1)
        return [i,nums.indexOf(target-nums[i])]
        }

        */

        // Solution3  use hashmap or  hashtable //Idictionary

        // IDictionary<type, type> numberNames = new Dictionary<type, type>
        // int[] n = {2,7,11,15};
       // int t = 9;
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] newArray = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {   
                int diff = target - nums[i];//2
                //step1: add numbers from nums array into dictionary dict
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i); //{(2,0),(7,1),(),()}
                }
                if (dict.ContainsKey(diff)) //{
                {
                    newArray[0] = dict[diff];//(2,0)
                    newArray[1] = i;//(1)

                    return newArray; //(0,1)
                }
               
                    
            }
            return newArray;
        }







    }
}
