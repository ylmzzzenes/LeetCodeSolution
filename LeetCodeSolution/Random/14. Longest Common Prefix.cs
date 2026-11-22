namespace LeetCodeSolution.Random
{
    public class _14
    {
        public string LongestCommonPrefix(string[] strs)
        {
          for(int i = 0; i < strs[0].Length; i++)
            {
                for(int j = 1; j<strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
          
          return strs[0];
        }
    }
}
