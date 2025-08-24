namespace MinDepthOfBinaryTree;

class Program
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        
        public TreeNode(int x, TreeNode left = null, TreeNode right = null) { 
            val = x;
            this.left = left; 
            this.right = right; 
        }
    }
    
    static void Main(string[] args)
    {

        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        // root.right = new TreeNode(20);
        // root.right.left = new TreeNode(15);
        // root.right.right = new TreeNode(7);
        // TreeNode root = new TreeNode(2);
        // root.right = new TreeNode(3);
        // root.right.right = new TreeNode(4);
        // root.right.right.right = new TreeNode(5);
        // root.right.right.right.right = new TreeNode(6);

        Console.WriteLine(MinDepth(root));
    }

    static int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        
        int bigger;
        
        if (left != 0 && left < right)
        {
            bigger = left;
        }
        else if (left != 0 && root.right == null)
        {
            bigger = left;
        }
        else if (right != 0 && root.left == null)
        {
            bigger = right;
        }
        else
        {
            bigger = right;
        }
        
        return 1 + bigger;
    }
    
    static int MinDepthDFS(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);

        if (left == 0 || right == 0)
        {
            return Math.Max(left, right) + 1;
        }
        
        return Math.Min(left, right) + 1;
    }
}