using System.ComponentModel.Design;

namespace CSharpCoding
{
    public static class ClosestValueInBst
    {
        // Average: O(log(n)) time | O(log(n)) space
        // worst: O(n) time | O(n) space

        public static int FindClosestValueInBst(BST tree, int target)
        {
            var closestValue = tree.value;
            return FindClosestValueInBstHelper(tree, target, closestValue);
        }

        public static int FindClosestValueInBstHelper(BST tree, int target, int closestValue)
        {
            if (tree == null)
            {
                return closestValue;
            }

            if (Math.Abs(target - closestValue) > Math.Abs(target - tree.value))
            {
                closestValue = tree.value;
            }

            if (target < tree.value)
            {
                return FindClosestValueInBstHelper(tree.left, target, closestValue);
            }
            else if (target > tree.value)
            {
                return FindClosestValueInBstHelper(tree.right, target, closestValue);
            }
            else
            {
                return closestValue;
            }
        }

        public static int FindClosestValueInBstIterative(BST tree, int target)
        {
            var closestValue = tree.value;
            while (tree != null)
            {
                if (Math.Abs(target - closestValue) > Math.Abs(target - tree.value))
                {
                    closestValue = tree.value;
                }

                if (target < tree.value)
                {
                    tree = tree.left;
                }
                else if (target > tree.value)
                {
                    tree = tree.right;
                }
                else
                {
                    break;
                }
            }

            return closestValue;
        }

    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }
}
