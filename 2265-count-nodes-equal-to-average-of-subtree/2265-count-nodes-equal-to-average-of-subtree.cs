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
    public int AverageOfSubtree(TreeNode root) {
        int res=0;
        int[] SumAndCount(TreeNode node){
            if(node == null) return new int[]{0,0};
            if(node.left==null&& node.right==null){
                res+=1;
               // Console.WriteLine($"Leaf = {node.val}");
                return new int[2]{node.val,1};
            }
            int[] left = SumAndCount(node.left);
            int[] right = SumAndCount(node.right);
            int[] toatl =  new int[]{left[0]+right[0]+node.val , left[1]+right[1]+1};
           // Console.WriteLine($"left = {left[0]} {left[1]} , right = {right[0]} {right[1]} ,total avg for{node.val} = {toatl[0]/toatl[1]}");
            if (toatl[0]/toatl[1] == node.val)
                res+=1;
            return toatl;
        }
        SumAndCount(root);
        return res;
    }
}