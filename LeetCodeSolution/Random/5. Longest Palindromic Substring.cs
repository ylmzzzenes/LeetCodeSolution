namespace LeetCodeSolution.Random
{
    public class _5
    {
        public string LongestPalindrome(string s)
        {
            int left;
            int right;
            string maxS = "";

            for(int i = 0; i < s.Length; i++)
            {
                
                    left = i;
                    right = i;

                    while(left>=0 && right < s.Length && s[left] == s[right])
                    {                       
                        left--;
                        right++;
                    }
                        int start = left + 1;
                        int length = right - left -1 ;

                        if (length > maxS.Length)
                        {
                            maxS = s.Substring(start, length);
                        }


                    left = i;
                    right = i + 1;
                    while (left >= 0 && right < s.Length && s[left] == s[right])
                    {                        
                        left--;
                        right++;
                    }
                start = left + 1;
                length = right - left -1;

                if (length > maxS.Length)
                {
                    maxS = s.Substring(start, length);
                }

            }
            return maxS;
          
        }
    }
}
