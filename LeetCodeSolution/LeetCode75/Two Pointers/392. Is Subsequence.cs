namespace LeetCodeSolution.LeetCode75.Two_Pointers
{
    public class _392
    {
        public bool IsSubsequence(string s, string t)
        {
            int stringS = 0;           
            int stringT = 0;


            while(stringS <  s.Length && stringT < t.Length)
            {
                if (s[stringS] == t[stringT])
                {
                    stringS++;
                }
                stringT++;
               
            }
            return stringS == s.Length;
        }
    }
}
