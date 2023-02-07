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
    public TreeNode BstFromPreorder(int[] preorder) {
        int n =preorder.Length;
        if(n==0) return null;
        
        TreeNode root = new();
        root.val = preorder[0];
        
        if(n==1) return root;
        
        int i;
        for(i=1;i<n;i++) if(preorder[i]>root.val)break;
        
        int[] left = preorder[1..i];
        int[] right = preorder[i..n];
        root.right = BstFromPreorder(right);
        root.left = BstFromPreorder(left);
        
        return root;
    }
}