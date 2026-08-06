using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75.Two_Pointers
{
    public class _11
    {
        public int MaxArea(int[] height)
        {            
            int left = 0;
            int right = height.Length - 1;
            int multiple = 1;
            int max = int.MinValue;

            while (left < right)
            {
                int min = Math.Min(height[left], height[right]);
                multiple = min * (right - left);
                
                if(max < multiple)
                {
                    max = multiple;
                }              
                left++;

            }
            
            return max;
        }
       
    }
}
