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
    public int GoodNodes(TreeNode root) {
        int res = 0;
        void DFS(TreeNode node,int max){
            if(node == null) return;
            //
            if(node.val>=max) res ++;
            DFS(node.left , Math.Max(max,node.val));
            DFS(node.right , Math.Max(max,node.val));
        }
        DFS(root,root.val);
        return res;
    }
}