namespace LeetCodeSolution.LeetCode75.Stack
{
    public class _2390
    {
        public string RemoveStars(string s)
        {
            Stack<Char> nonStarChracter = new();

            foreach (var a in s)
            {
                if(a == '*')
                {
                    if(nonStarChracter.Count>0)
                    nonStarChracter.Pop();
                }

                nonStarChracter.Push(a);
            }

            return new string(nonStarChracter.Reverse().ToArray());
        }
    }
}
