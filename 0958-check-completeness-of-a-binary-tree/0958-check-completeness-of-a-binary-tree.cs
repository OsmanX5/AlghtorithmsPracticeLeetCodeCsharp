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
    public bool IsCompleteTree(TreeNode root) {
        Queue<TreeNode?> BFS = new Queue<TreeNode?>();
        BFS.Enqueue(root);
        TreeNode? Last =root;
        while(BFS.Count>0){
            TreeNode? currentNode = BFS.Dequeue();
            if(currentNode !=null){
                if(Last ==null)return false;
                BFS.Enqueue(currentNode.left);
                BFS.Enqueue(currentNode.right);
            }
            Last = currentNode;
        }
        return true;
    }
}