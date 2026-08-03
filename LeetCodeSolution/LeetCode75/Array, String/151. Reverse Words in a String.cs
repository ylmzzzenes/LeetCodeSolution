using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75
{
    public class _151
    {
        public string ReverseWords(string s)
        {
            
            string[] parts = s.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] reverse = new string[parts.Length];
            int left =parts.Length - 1;
            int right =0;

            while (right < parts.Length)
            {
                reverse[right] = parts[left];
                right++;
                left--;
            }



            string a = string.Join(" ",reverse);
                       
            return a;
        }
    }
}
