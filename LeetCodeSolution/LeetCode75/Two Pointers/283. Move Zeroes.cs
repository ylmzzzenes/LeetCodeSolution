namespace LeetCodeSolution.LeetCode75.Two_Pointers
{
    public class _283
    {
        public void MoveZeroes(int[] nums)
        {
            int left = 0;
            int right = 0;

            while (right < nums.Length && left < nums.Length)
            {
                if (nums[left] == 0)
                {
                    int temp = nums[left];

                    if (nums[right] == 0)
                    {
                        right++;

                    }
                    else
                    {
                        nums[left] = nums[right];
                        nums[right] = temp;
                        left++;
                        right++;
                    }
                }
            }
        }
    }
}
