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
    public TreeNode BstToGst(TreeNode root) {
        SUM(root);
        return root;

    }
    int sum=0;
    public int SUM(TreeNode node){
        if(node== null) 
            return 0;
        SUM(node.right);
        
        //Console.WriteLine($"visit {node.val}");
        sum+= node.val;
        node.val = sum;

        SUM(node.left);
        
        return  node.val;
    }
}