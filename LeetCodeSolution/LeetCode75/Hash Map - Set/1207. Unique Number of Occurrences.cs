namespace LeetCodeSolution.LeetCode75.Hash_Map___Set
{
    public class _1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach(int num in arr)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
               
            }
            var occurrences = new HashSet<int>(countMap.Values);

            return countMap.Count == occurrences.Count;
        }
    }
}
