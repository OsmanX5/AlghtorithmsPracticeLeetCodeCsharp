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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> res =new List<int>();
        void DFS(TreeNode node){
            if(node==null) return;
            DFS(node.left);
            res.Add(node.val);
            DFS(node.right);
        }
        DFS(root1);
        DFS(root2);
        res.Sort();
        return res;
    }
}