using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    internal class _1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            int minCount = Math.Min(str1.Length, str2.Length);
            int maxCount = Math.Max(str1.Length, str2.Length);
            string output = string.Empty;
            string output1 = string.Empty;
            int count = 0;

            if (maxCount % minCount == 2)
            {
                count = 2;
            }
            if (str1 + str2 == str2 + str1)
            {

                for (int i = 0; i < minCount; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        output += str2[i];
                    }

                }
                if (output.Length % 2 == 0)
                {
                    output1 += output[0];
                    output1 += output[1];
                    return output1;
                }
            }


            return output;

        }
    }
}
