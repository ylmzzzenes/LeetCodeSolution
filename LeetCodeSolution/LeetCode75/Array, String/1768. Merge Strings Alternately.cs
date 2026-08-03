using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    internal class _1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            int maxCount = Math.Max(word1.Length, word2.Length);
            char[] w1 = word1.ToCharArray();
            char[] w2 = word2.ToCharArray();
            string mergedString = string.Empty;

            for (int i = 0; i < maxCount; i++)
            {
                if (i < word1.Length)
                {
                    mergedString += w1[i].ToString();
                }
                if (i < word2.Length)
                {
                    mergedString += w2[i].ToString();
                }
            }

            return mergedString;
        }
    }
}
