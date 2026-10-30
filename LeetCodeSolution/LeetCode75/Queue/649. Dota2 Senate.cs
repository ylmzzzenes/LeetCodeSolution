namespace LeetCodeSolution.LeetCode75.Queue
{
    public class _649
    {
        public string PredictPartyVictory(string senate)
        {
            int n = senate.Length;
            Queue<int> dire = new();
            Queue<int> radiant = new();

            for(int i = 0; i < n; i++)
            {
                if (senate[i] == 'R')
                {
                    radiant.Enqueue(i);
                }
                dire.Enqueue(i);
            }

            while(radiant.Count > 0 && dire.Count > 0)
            {
                int radiantIndex = radiant.Dequeue();
                int direIndex = dire.Dequeue();

                if (radiantIndex < direIndex)
                {
                    radiant.Enqueue(radiantIndex +n);
                }
                else
                {
                    dire.Enqueue(direIndex + n);
                }
            }

            return radiant.Count > 0 ? "Radiant" : "Dire";
        }
    }
}
