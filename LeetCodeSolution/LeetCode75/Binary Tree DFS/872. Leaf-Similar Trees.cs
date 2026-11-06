namespace LeetCodeSolution.LeetCode75.Binary_Tree_DFS
{
    public class _872
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            // solution 1
            #region
            var leaves1 = new List<int>();
            var leaves2 = new List<int>();

            void CollectLeaves(TreeNode? node, List<int> leaves)
            {
                if (node == null)
                    return;

                if (node.left == null && node.right == null)
                {
                    leaves.Add(node.val);
                }
                else
                {
                    CollectLeaves(node.left, leaves);
                    CollectLeaves(node.right, leaves);
                }

                CollectLeaves(root1, leaves1);
                CollectLeaves(root2, leaves2);
            }

            return leaves1.SequenceEqual(leaves2);
            #endregion

            // solution 2
            #region
            //List<int> leaves1 = new();
            //List<int> leaves2 = new();

            //CollectLeaves(root1).ForEach(x => leaves1.Add(x));
            //CollectLeaves(root2).ForEach(x => leaves2.Add(x));
            //List<int> CollectLeaves(TreeNode root)
            //{
            //    List<int> leaves = new();
            //    Stack<TreeNode> stack = new();
            //    stack.Push(root);
            //    while (stack.Count > 0)
            //    {
            //        TreeNode node = stack.Pop();
            //        if (node.left == null && node.right == null)
            //        {
            //            leaves.Add(node.val);
            //        }
            //        else
            //        {
            //            if (node.right != null)
            //            {
            //                stack.Push(node.right);
            //            }
            //            if (node.left != null)
            //            {
            //                stack.Push(node.left);
            //            }
            //        }
            //    }
            //    return leaves;
            //}


            //return leaves1.SequenceEqual(leaves2);
            #endregion
        }
    }
}