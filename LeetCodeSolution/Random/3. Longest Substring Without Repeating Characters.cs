namespace LeetCodeSolution.Random
{
    public class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> seen = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }
                seen.Add(s[right]);

                maxLength = Math.Max(right - left + 1, maxLength);
            }
         
            return maxLength;
        }
    }
}
