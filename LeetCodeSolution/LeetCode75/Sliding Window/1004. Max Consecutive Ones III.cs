namespace LeetCodeSolution.LeetCode75.Sliding_Window
{
    public class _1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, zeros = 0, maxLength = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeros++;
                }

                while (zeros > k)
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
