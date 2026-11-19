namespace LeetCodeSolution.Random
{
    public class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //// solution 1: brute force
            //#region
            //List<int> output = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            output.Add(i);
            //            output.Add(j);
            //            break;
            //        }
            //    }
            //}

            //return output.ToArray();
            //#endregion

            // solution 2: Dictionary

            Dictionary<int, int>  numMap = new Dictionary<int, int>();

            for (int i = 0; i< nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                numMap.TryAdd(nums[i], i);

            }
            return null;

        }
    }
}