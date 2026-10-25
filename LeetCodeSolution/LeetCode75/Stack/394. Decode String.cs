namespace LeetCodeSolution.LeetCode75.Stack
{
    public class _394
    {
        public string DecodeString(string s)
        {
            Stack<(int count, string previous)> stack = new();
            int currentNumber = 0;
            String currentString= "";

            foreach(var i in s)
            {
                if (char.IsDigit(i))
                {
                    int digit = i - '0';
                    currentNumber = currentNumber * 10 + digit;
                }
                else if (i == '[')
                {
                    stack.Push((currentNumber, currentString));
                    currentNumber = 0;
                    currentString = "";
                }
                else if (i == ']')
                {
                    var state = stack.Pop();
                    var repeatCount = state.count;
                    var previousString = state.previous;
                    currentString = previousString + string.Concat(Enumerable.Repeat(currentString, repeatCount));
                }
                else
                {
                    currentString += i;
                }
               
            }
            return currentString.ToString();
        }
    }
}
