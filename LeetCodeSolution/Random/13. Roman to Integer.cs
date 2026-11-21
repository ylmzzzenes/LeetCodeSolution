namespace LeetCodeSolution.Random
{
    public class _13
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romens = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(i < s.Length -1 && romens[s[i]] < romens[s[i + 1]])
                {
                    result -= romens[s[i]];
                }
                else
                {
                    result += romens[s[i]];
                }
            }

            return result;
        }
    }
}
