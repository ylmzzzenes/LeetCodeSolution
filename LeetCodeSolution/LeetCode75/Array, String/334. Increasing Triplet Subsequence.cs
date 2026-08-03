using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75
{
    public class _334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;

            for(int i =0; i< nums.Length; i++)
            {
                if (nums[i] <= first)
                {
                    first = nums[i];
                }
                else if (nums[i] < second)
                {
                    second = nums[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
