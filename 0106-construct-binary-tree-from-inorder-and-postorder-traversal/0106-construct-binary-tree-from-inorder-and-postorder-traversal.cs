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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int n = postorder.Length;
        if(n<1) return null;
        int rootValue = postorder[n-1];
        TreeNode root = new TreeNode(rootValue);
        int rootIndexInInorder = Array.IndexOf(inorder,rootValue);
        int[] leftInOrder = inorder[0..rootIndexInInorder];
        int[] leftPostOrder = postorder[0..rootIndexInInorder];
        int[] rightInOrder = inorder[(rootIndexInInorder+1)..n];
        int[] rightPostOrder =postorder[rootIndexInInorder..(n-1)];
        root.left = BuildTree(leftInOrder,leftPostOrder);
        root.right = BuildTree(rightInOrder,rightPostOrder);
        return root;
    }
}