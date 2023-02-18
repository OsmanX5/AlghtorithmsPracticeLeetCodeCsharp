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
    public int target;
    public bool HasPathSum(TreeNode root, int targetSum) {
        target = targetSum;
        return helper(root,0);
    }
    public bool helper(TreeNode node,int sum){
        if(node == null) return false;
        sum = sum + node.val;
        node.val = sum;
        if(node.left ==null && node.right == null){
            if(sum == target)return true;
            else return false;
        }
        return helper(node.left,sum) || helper(node.right,sum);
    }
}