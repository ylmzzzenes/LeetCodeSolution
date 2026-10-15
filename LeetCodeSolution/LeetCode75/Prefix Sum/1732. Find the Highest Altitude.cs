namespace LeetCodeSolution.Prefix_Sum
{
    public class _1732
    {
        public int LargestAltitude(int[] gain)
        {
            int currentAltitude = 0;
            int maxAltitude = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                currentAltitude += gain[i];
                maxAltitude = Math.Max(currentAltitude, maxAltitude);
            }

            return maxAltitude;
        }
    }
}
