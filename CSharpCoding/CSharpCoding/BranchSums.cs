namespace CSharpCoding
{
    public static class BranchSums
    {
        public static List<int> BranchSumsSolution(BinaryTree? root)
        {
            var returnList = new List<int>();
            BranchSumsSolutionHelper(root, 0, returnList);

            return returnList;
        }

        public static void BranchSumsSolutionHelper(BinaryTree? node, int runningSum, List<int> sums)
        {
            if (node == null)
            {
                return;
            }
            var newRunningSum = runningSum + node.value;

            if (node.left == null && node.right == null)
            {
                sums.Add(newRunningSum);
                return;
            }

            BranchSumsSolutionHelper(node.left, newRunningSum, sums);
            BranchSumsSolutionHelper(node.right, newRunningSum, sums);

        }
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree? left;
        public BinaryTree? right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    
}
