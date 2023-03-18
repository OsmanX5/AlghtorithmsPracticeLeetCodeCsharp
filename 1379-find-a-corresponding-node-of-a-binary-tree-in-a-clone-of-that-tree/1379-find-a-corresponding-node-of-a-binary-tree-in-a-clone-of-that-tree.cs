/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        TreeNode res = new TreeNode();
        void DFS(TreeNode node){
            if(node == null) return;
            if(node.val == target.val)
                res = node;
            DFS(node.left);
            DFS(node.right);
        }
        DFS(cloned);
        return res;
    }
}
/*
        void DFS(TreeNode node){
            if(node == null) return;
            
            DFS(node.left);
            DFS(node.right);
        }
    */