using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75.Sliding_Window
{
    public class _1456
    {
        public int MaxVowels(string s, int k)
        {
            int count = 0;
            int a = 0;
            int b = k;
            int newCount = 0;
            while (a < s.Length - 2)
            {

                
                for (int i = a; i < b ; i++)
                {                   
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        count++;
                    }
                }
                
                newCount = Math.Max(newCount, count);
                a++;
                b++;
                count = 0;
            }
            return newCount;
        }
    }
}
