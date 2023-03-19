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
    public TreeNode BalanceBST(TreeNode root) {
        List<int> arr = new List<int>();
        void DFS(TreeNode node){
            if(node==null)return;
            DFS(node.left);
            arr.Add(node.val);
            DFS(node.right);
        }
        TreeNode CrateBST(int[] nodes){
            int n = nodes.Length;
            if(n==0)return null;
            TreeNode r = new TreeNode(nodes[0]);
            if(n<=2){
                if(n==2) r.right = new TreeNode(nodes[1]);
                return r;
            }
            int mid = n/2;
            int[] leftChilds = nodes[0..mid];
            int[] rightChilds = nodes[(mid+1)..n];
            r = new TreeNode(nodes[mid]);
            r.right = CrateBST(rightChilds);
            r.left = CrateBST(leftChilds);
            return r;
        }
        DFS(root);
        arr.ForEach(x => Console.Write($" {x} "));
        int[] nodes = arr.ToArray();
        return CrateBST(nodes);
    }
}