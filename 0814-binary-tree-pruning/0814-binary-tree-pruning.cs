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
    public TreeNode PruneTree(TreeNode root) {
        
        
        bool ContaineOne(TreeNode node){
            if(node == null) return false;
            bool rightContainsOne = ContaineOne(node.right);
            bool leftContainsOne = ContaineOne(node.left);
            if(!leftContainsOne)
                node.left = null;
            if(!rightContainsOne)
                node.right =null;
            return node.val == 1 || leftContainsOne || rightContainsOne;
        }
        if (!ContaineOne(root)) return null;
        return root;
    }
}