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
    public int SumOfLeftLeaves(TreeNode root) {
        int sum =0;
        void DFS(TreeNode node,bool isLeft){
            if(node == null) return;
            if(node.left==null && node.right ==null){
                if(isLeft)sum += node.val;
            }
            DFS(node.left ,true);
            DFS(node.right,false);
        }
        DFS(root,false);
        return sum;
    }
}