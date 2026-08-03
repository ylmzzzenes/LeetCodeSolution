namespace LeetCodeSolution.LeetCode75
{
    public class _443
    {
        public int Compress(char[] chars)
        {
            int read = 0;
            int write = 0;
            int count = 1;

            while (read < chars.Length)
            {
                while (read + 1 < chars.Length  && chars[read] == chars[read +1] )
                {
                    read++;
                    count++;
                }
                chars[write] = chars[read];
                write++;
                string splitCount = count.ToString();
                if (count > 1)
                {
                    foreach(var c in splitCount)
                    {
                        chars[write] = c;
                        write++;
                    }
                }
                count = 1;
            }

            return write;
        }
    }
}
