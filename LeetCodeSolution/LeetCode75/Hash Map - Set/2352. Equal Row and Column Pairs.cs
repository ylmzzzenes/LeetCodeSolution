namespace LeetCodeSolution.LeetCode75.Hash_Map___Set
{
    public class _2352
    {
        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            int count = 0;
            Dictionary<string, int> rowMap = [];

            foreach (var row in grid)
            {
                string key = string.Join(",", row);

                if (rowMap.ContainsKey(key))
                {
                    rowMap[key] = count++;
                }
                else
                {
                    
                        rowMap[key] = 1;
                    
                }

            }

            for(int i = 0; i < n; i++)
            {
                int[] col = new int[n];
                for(int r = 0; r < n; r++)
                
                    col[r] = grid[r][i];
                    string colKey = string.Join(",", col);
                

                if (rowMap.ContainsKey(colKey))
                {
                    count++;
                }
            }

            return count;
            
        }
    }
}
