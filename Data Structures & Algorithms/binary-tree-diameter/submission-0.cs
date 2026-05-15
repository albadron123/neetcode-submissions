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

 public struct Param
 {
    public int height;
    public int diam;
    public Param(int h, int d)
    {
        height = h;
        diam = d;
    }
 }

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        return GetDiam(root).diam;
    }

    private Param GetDiam(TreeNode root)
    {
        if(root.left == null && root.right == null)
        {
            return new Param(0, 0);
        }
        if(root.left == null)
        {
            Param right = GetDiam(root.right);
            return new Param(right.height+1, Math.Max(right.height+1,right.diam));
        }
        else if (root.right == null)
        {
            Param left = GetDiam(root.left);
            return new Param(left.height+1, Math.Max(left.height+1,left.diam));
        }
        else
        {
            Param right = GetDiam(root.right);
            Param left = GetDiam(root.left);
            return new Param(Math.Max(left.height, right.height) + 1, 
                             Math.Max(Math.Max(left.diam, right.diam), left.height + right.height + 2));
        }
        
    }
}
