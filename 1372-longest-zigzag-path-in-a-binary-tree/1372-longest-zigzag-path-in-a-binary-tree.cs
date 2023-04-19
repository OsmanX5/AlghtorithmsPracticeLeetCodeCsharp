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
    public int LongestZigZag(TreeNode root) {
        int max =0;
        
        void ZigZag(TreeNode node,bool LastIsLeft,int depth){
            if(node == null) return;
            max = Math.Max(max,depth);
            if(LastIsLeft){
                ZigZag(node.left,false,depth+1);
                ZigZag(node.right,true,1);
            }
            else{
                ZigZag(node.left,false,1);
                ZigZag(node.right,true,depth+1);
            }
            
        }
        ZigZag(root,true,0);
        ZigZag(root,false,0);
        return max;
    }
}