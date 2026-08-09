namespace LeetCodeSolution.LeetCode75.Sliding_Window
{
    public class _643
    {
        public double FindMaxAverage(int[] nums, int k)
        {

            int left = 0;
            double avg = 0;
            double max = double.MinValue;
            int a = k;

            while (left < nums.Length)
            {
                avg = 0;
                for (int slideLeft = left; slideLeft < k; slideLeft++)
                {
                    avg += nums[slideLeft];
                }
                avg = avg / a;

                if (max < avg)
                {
                    max = avg;
                }

                if (nums.Length - 1 - left < k)
                {
                    break;
                }
                left++;
                k++;
            }
            return max;
        }
    }
}
