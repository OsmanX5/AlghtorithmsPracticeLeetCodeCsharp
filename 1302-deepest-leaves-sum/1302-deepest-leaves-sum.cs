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
    public int DeepestLeavesSum(TreeNode root) {
        int sum =0;
        int maxDepth =0;
        void DFS(TreeNode node,int depth){
            if(node ==null)return;
            if(node.right==null &&node.left==null){
                if(depth>maxDepth){
                    maxDepth= depth;
                    sum = node.val;
                }
                else if(depth == maxDepth){
                    sum += node.val;
                }
            }
            DFS(node.right,depth+1);
            DFS(node.left,depth+1);
        }
        DFS(root,0);
        return sum;
    }
    
}