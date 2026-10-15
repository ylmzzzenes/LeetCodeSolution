namespace LeetCodeSolution.LeetCode75.Hash_Map___Set
{
    public class _2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            // solution 1
            #region
            // HashSet<int> set1 = new();
            // HashSet<int> set2 = new();
            // List<int> onlyInFirst = new();
            // List<int> onlyInSecond = new();
            // List<IList<int>> answer = new();


            // foreach (var i in nums1)
            // {
            //     set1.Add(i);
            // }

            // foreach(var i in nums2)
            // {
            //     set2.Add(i);
            // }

            //foreach(int number in set1)
            // {
            //     if (!set2.Contains(number))
            //     {
            //         onlyInFirst.Add(number);
            //     }
            // }
            //foreach(int number in set2)
            // {
            //     if (!set1.Contains(number))
            //     {
            //         onlyInSecond.Add(number);
            //     }
            // }

            // answer.Add(onlyInFirst);
            // answer.Add(onlyInSecond);

            // return answer;
            #endregion

            //solution 2
            #region
            HashSet<int> set1 = new(nums1);
            HashSet<int> set2 = new(nums2);
            HashSet<int> copySet1 = new(nums1);
            List<IList<int>> answer = new();


            set1.ExceptWith(set2);
            set2.ExceptWith(set1);
            answer.Add(set1.ToList());
            answer.Add(set2.ToList());

            return answer;
            #endregion
        }
    }
}
