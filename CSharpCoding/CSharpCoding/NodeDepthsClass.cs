namespace CSharpCoding
{
    public static class NodeDepthsClass
    {

        // average case: when tree is balanced
        // O(n) time | O(h) space - where n is the number of nodes and h is the height
        public static int NodeDepths(BinaryTree root)
        {
            return nodeDepthsHelper(root, 0);
        }

        public static int nodeDepthsHelper(BinaryTree root, int depth)
        {
            if (root == null) return 0;
            return depth + nodeDepthsHelper(root.left, depth + 1) + nodeDepthsHelper(root.right, depth + 1);
        }

        public class Level
        {
            public BinaryTree Root;
            public int Depth;

            public Level(BinaryTree root, int depth)
            {
                this.Root = root;
                this.Depth = depth;
            }
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
	}
}
