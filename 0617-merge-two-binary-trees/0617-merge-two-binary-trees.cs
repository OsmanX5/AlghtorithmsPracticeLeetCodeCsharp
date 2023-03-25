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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1==null && root2!=null){
            return root2;
        }
        DFS(root1,root2);
        return root1;
    }
    public void DFS(TreeNode node1,TreeNode node2){
        if(node1==null ) return;
        
        int val2 = node2 == null? 0:node2.val;
        node1.val += val2;
        
        if(node1?.left==null && node2?.left!=null)
            node1.left = new TreeNode(0);
        if(node1?.right==null && node2?.right!=null)
            node1.right = new TreeNode(0);
        
        DFS(node1?.left,node2?.left);
        DFS(node1?.right,node2?.right);
    }
}