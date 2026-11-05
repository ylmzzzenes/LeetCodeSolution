namespace LeetCodeSolution.LeetCode75.Binary_Tree_DFS
{
    public class _104
    {
        public int MaxDepth(TreeNode? root)
        {
            if (root == null)
                return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
