/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        return (Height(root) != -1);
    }

    public int Height(TreeNode root)
    {
        if(root == null) return 0;
        int l = Height(root.left);
        int r = Height(root.right);
        if(l == -1 || r == -1) return -1;
        if(Math.Abs(l-r) > 1) return -1;
        return Math.Max(l,r)+1;
    }
}
