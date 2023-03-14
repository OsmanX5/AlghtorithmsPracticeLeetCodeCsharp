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
    public int SumNumbers(TreeNode root) {
        int res =0;
        void DFS(TreeNode node,int sum){
            if(node==null)return;
            sum = sum*10+node.val;
            if(node.left==null && node.right==null)
                res += sum;
            DFS(node.right,sum);
            DFS(node.left,sum);
        }
        DFS(root,0);
        return res;
    }

}