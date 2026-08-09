using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75.Two_Pointers
{
    public class _1679
    {
        public int MaxOperations(int[] nums, int k)
        {
            int left = 0;
            int right = nums.Length - 1;
            int output = 0;

            while (left < right)
            {
                if (nums[left] + nums[right] == k)
                { 
                    output++;                 
                }

                if(right - left %  2 == 1)
                {
                    break;
                }
                left++;
                right--;

            }
            return output;
        }
    }
}
