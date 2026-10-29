namespace LeetCodeSolution.LeetCode75.Queue
{
    public class RecentCounter
    {
        private readonly Queue<int> q = new();
        public RecentCounter()
        {          
        }

        public int Ping(int t)
        {
            q.Enqueue(t);

            while(q.Peek() < t - 3000)
            {
                q.Dequeue();
            }
            return q.Count;
        }
    }
}
