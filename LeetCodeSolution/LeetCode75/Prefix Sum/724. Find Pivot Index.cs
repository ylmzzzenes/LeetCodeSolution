namespace LeetCodeSolution.Prefix_Sum
{
    public class _724
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int totalSum = nums.Sum();

            for(int i = 0; i < nums.Length; i++)
            {
                int rightSum = totalSum - leftSum - nums[i];

                if(leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;

            
        }
    }
}
