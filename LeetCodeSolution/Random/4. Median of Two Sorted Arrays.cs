namespace LeetCodeSolution.Random
{
    public class _4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            int m = nums1.Length;
            int n = nums2.Length;

            int left = 0;
            int right = m;

            while (left <= right)
            {
                int partition1 = left + (right - left) / 2;
                int partition2 = (m + n + 1) / 2 - partition1;

                int L1 = partition1 == 0 ? int.MinValue : nums1[partition1 - 1];
                int R1 = partition1 == m ? int.MaxValue : nums1[partition1];

                int L2 = partition2 == 0 ? int.MinValue : nums2[partition2 - 1];
                int R2 = partition2 == n ? int.MaxValue : nums2[partition2];

                if (L1 <= R2 && L2 <= R1)
                {
                    if ((m + n) % 2 == 0)
                        return (Math.Max(L1, L2) + (double)Math.Min(R1, R2)) / 2.0;

                    return Math.Max(L1, L2);
                }
                else if (L1 > R2)
                {
                    right = partition1 - 1;
                }
                else
                {
                    left = partition1 + 1;
                }
            }

            throw new ArgumentException("Geçersiz sıralı diziler.");
        }
    }
    
}
