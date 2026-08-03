using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75
{
    public class _238
    {
        public int[] ProductExceptSelf(int[] nums)
        {

            int rightProduct = 1;
            int[] output = new int[nums.Length];

            output[0] = 1;

            for(int i = 1; i< nums.Length; i++)
            {
                output[i] = output[i-1] * nums[i-1];

            }

            for(int i =  nums.Length -1; 0<= i; i--)
            {
                output[i] = output[i] * rightProduct;
                rightProduct = rightProduct * nums[i];
            }

            return output;
        }
    }
}
