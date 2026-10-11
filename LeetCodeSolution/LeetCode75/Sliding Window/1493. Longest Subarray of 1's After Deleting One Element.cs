using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75.Sliding_Window
{
    public class _1493
    {
        public int LongestSubarray(int[] nums)
        {
            int left = 0, zeros = 0, maxLength = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeros++;
                }

                while(zeros > 1)
                {
                    if (nums[left] == 0)
                    {
                        zeros--;
                    }
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
    }
}
