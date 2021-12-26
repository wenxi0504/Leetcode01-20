using System;

namespace Q16_3SumClose
{
    /*Given an integer array nums of length n and an integer target, 
     *find three integers in nums such that the sum is closest to target.
     *Return the sum of the three integers.
     *You may assume that each input would have exactly one solution.
     * Input: nums = [-1,2,1,-4], target = 1
     *Output: 2
     *Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
     *Input: nums = [0,0,0], target = 1
     *Output: 0
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 2, 1, -4 }, nums1= {0,0,0};
            Console.WriteLine(ThreeSumClosest(nums,1));
            Console.WriteLine(ThreeSumClosest(nums1, 1));
        }

        public static int ThreeSumClosest(int[] nums, int target)
        {   int i = 0;
            int res = 0;
            int minGap = int.MaxValue;//assume that the initial minimum gap is the max value
            //step 1 sort array
            Array.Sort(nums);
            for (i = 0; i < nums.Length-2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j<k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    int gap = Math.Abs(sum - target);//0,1
                    if (gap < minGap)
                    {
                        res = sum;
                        minGap = gap;
                    }
                    if (sum<target)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }


            }
            return res;
        }
    }
}
