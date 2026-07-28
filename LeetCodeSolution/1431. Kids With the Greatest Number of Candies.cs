using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    public class _1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            IList<bool> list = new List<bool>();
            
                int maxCandies = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (maxCandies < candies[i])
                    maxCandies = candies[i];
                if (maxCandies <= candies[i] + extraCandies)
                {
                  list.Add(true);
                }
                else
                {
                    list.Add(false);
                }

            }

            return list;
        }
    } }
