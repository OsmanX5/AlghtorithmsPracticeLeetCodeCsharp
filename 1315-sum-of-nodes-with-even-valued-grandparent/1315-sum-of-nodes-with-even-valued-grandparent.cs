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
    public int SumEvenGrandparent(TreeNode root) {
        int sum=0;
        void DFS(TreeNode node,int parent,int grandParent){
            if(node==null) return;
            if(grandParent%2==0) sum += node.val;
            DFS(node.right,node.val,parent);
            DFS(node.left,node.val,parent);
        }
        DFS(root,-1,-1);
        return sum;
    }
}