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
    public TreeNode DeleteNode(TreeNode root, int key) {
        
        return Search(root,key);
    }
    public TreeNode Search(TreeNode node, int key){
        if(node == null) return null ;
        if(key == node.val){
            if(node.right==null && node.left==null)
                return null;
            if(node.right!=null && node.left!=null){
                TreeNode toSwab = Successor(node.right);
                Console.Write($"swabing {node.val} with {toSwab.val}");
                (node.val,toSwab.val) = (toSwab.val,node.val);
                node.right = Search(node.right,key);
            }
            else if(node.right!=null) return node.right;
            else return node.left;
        }
        else if(key>node.val) node.right = Search(node.right,key);
        else node.left = Search(node.left,key);
        return node;
        
    }
    public TreeNode Successor(TreeNode node){
        if(node ==null) return null;
        TreeNode left = Successor(node.left);
        if(left !=null) return left;
        if(node.left ==null) return node;
        TreeNode right = Successor(node.right);
        return right;
    }
}