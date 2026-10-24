namespace LeetCodeSolution.LeetCode75
{
    public class _735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> leftAstreoids = new();

            foreach(var a in asteroids)
            {
                if (a > 0)
                {
                    leftAstreoids.Push(a);
                }
                else
                {
                    while (leftAstreoids.Count > 0 && leftAstreoids.Peek() > 0 && leftAstreoids.Peek() < -a )
                    {
                        leftAstreoids.Pop();
                    }
                    if(leftAstreoids.Count == 0 || leftAstreoids.Peek() < 0)
                    {
                        leftAstreoids.Push(a);
                    }
                    else if (leftAstreoids.Peek() == -a)
                    {
                        leftAstreoids.Pop();
                    }
                }
            }

            return leftAstreoids.Reverse().ToArray();
        }
    }
}
