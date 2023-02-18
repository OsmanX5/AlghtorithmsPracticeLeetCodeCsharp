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
    public TreeNode InvertTree(TreeNode root) {
        if(root ==null) return null;
        TreeNode newLeft = InvertTree(root.left);
        TreeNode newRight = InvertTree(root.right);
        root.left = newRight;
        root.right = newLeft;
        return root;
        
    }
}