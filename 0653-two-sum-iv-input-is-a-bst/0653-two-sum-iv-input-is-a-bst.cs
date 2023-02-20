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
    public bool FindTarget(TreeNode root, int k) {
        List<int> sorted = new List<int>();
        void DFS(TreeNode node){
            if(node==null) return;
            DFS(node.left);
            sorted.Add(node.val);
            DFS(node.right);
        }
        DFS(root);
        int n= sorted.Count;
        int l=0;
        int r=n-1;
        while(l<r){
            int sum =  sorted[l]+sorted[r];
            if(sum ==k)return true;
            if( sum<k) l++;
            else r--;
        }
        return false;
    }
}