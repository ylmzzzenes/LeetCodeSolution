namespace LeetCodeSolution.LeetCode75.Hash_Map___Set
{
    public class _1657
    {
        public bool CloseStrings(string word1, string word2)
        {
            // solution1
            #region
            if (word1.Length != word2.Length)
                return false;

            HashSet<char> set1 = new(word1);
            HashSet<char> set2 = new(word2);

            bool check = set1.SetEquals(set2);

            return check == true ? true : false;
            #endregion

            //solution2
            #region
            //if (word1.Length != word2.Length)
            //{
            //    return false;
            //}

            //Dictionary<char, int> frequency1 = [];
            //Dictionary<char, int> frequency2 = [];

            //foreach(var character in word1)
            //{
            //    if (frequency1.ContainsKey(character))
            //    {
            //        frequency1[character]++;
            //    }
            //    else
            //    {
            //        frequency1[character] = 1;
            //    }
            //}

            //foreach (var character in word2)
            //{
            //    if (frequency2.ContainsKey(character))
            //    {
            //        frequency2[character]++;
            //    }
            //    else
            //    {
            //        frequency2[character] = 1;
            //    }
            //}

            //return  frequency1.Values.OrderBy(X => X).SequenceEqual(frequency2.Values.OrderBy(X => X));
            #endregion
        }
    }
}
