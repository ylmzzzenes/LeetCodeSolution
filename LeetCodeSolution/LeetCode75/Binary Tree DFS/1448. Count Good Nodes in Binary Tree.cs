namespace LeetCodeSolution.LeetCode75.Binary_Tree_DFS
{
    public class _1448
    {
        public int GoodNodes(TreeNode root)
        {
            int goodsCount = 0;

            if (root == null) return 0;

            void DFS(TreeNode node, int maxval)
            {
                if (node == null) return;
                if (node.val >= maxval)
                {
                    goodsCount++;
                    maxval = node.val;
                }
                DFS(node.left, maxval);
                DFS(node.right, maxval);
            }

            DFS(root, root.val);
            return goodsCount;
        }
    }
}
