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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BST(nums);
    }
    TreeNode BST(int[] nums){
        int n = nums.Length;
        if(n==0) return null;
        int mid = n/2;
        TreeNode root = new TreeNode(nums[mid]);
        int[] LeftNums = nums[0..mid];
        int[] RightNums = nums[(mid+1)..n];
        root.right =BST(RightNums);
        root.left = BST(LeftNums);
        return root;
    }
}