using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution.LeetCode75
{
    internal class _345
    {
        public string ReverseVowels(string s)
        {           
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };      
            int left = 0;
            int right = s.Length-1;
            char[] newS = s.ToCharArray();
            while (left < right )
            {
               while(left < right && !vowels.Contains(newS[left]))
                {
                    left++;
                }
               while(left<right && !vowels.Contains(newS[right]))
                {
                    right--;
                }

                char temp = newS[left];
                newS[left] = newS[right];
                newS[right] = temp;
                left++;
                right--;

                
            }
          
            return new string(newS);
        }
    }
}
