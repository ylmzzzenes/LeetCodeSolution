using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75
{
    public class _238
    {
        public int[] ProductExceptSelf(int[] nums)
        {

            int leftproduct = 1; 
            int rightproduct = 1;
            int[] answer = new int[nums.Length];

            answer[0] = 1;

            for(int i = 1; i< nums.Length; i++)
            {
                answer[i] = answer[i-1] * nums[i-1];
            }

            for(int i = nums.Length-1; 0 <= i; i--)
            {
                answer[i] = answer[i] * rightproduct;
                rightproduct = rightproduct * nums[i];
            }

            return answer;
        }
    }
}
