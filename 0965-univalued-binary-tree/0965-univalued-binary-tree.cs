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
    public bool IsUnivalTree(TreeNode root) {
        Queue<TreeNode> BFS = new Queue<TreeNode>();
        BFS.Enqueue(root);
        int val = root.val;
        while(BFS.Count>0)
        {
            TreeNode x = BFS.Dequeue();
            if(x.val!= val)
                return false;
            if(x.right!=null) BFS.Enqueue(x.right);
            if(x.left!=null) BFS.Enqueue(x.left);
        }
        return true;
    }
}