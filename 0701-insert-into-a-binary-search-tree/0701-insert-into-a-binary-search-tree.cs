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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        return Inserter(root,root,val);
    }
    public TreeNode Inserter(TreeNode node,TreeNode parent,int val){
        if(node == null){
            TreeNode created = new TreeNode(val);
            if(parent==null) return created;
            if(val>parent.val)parent.right = created;
            else parent.left = created;
        }
        else if(val>node.val) Inserter(node.right,node,val);
        else Inserter(node.left,node,val);
        return node;
    }
}