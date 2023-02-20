/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        List<int> pathA = pathFromRoot(root,p);
        List<int> pathB = pathFromRoot(root,q);

        int m = Math.Min(pathA.Count, pathB.Count);
        for(int i=0;i<m;i++){
            if(pathA[i]!=pathB[i]) return new TreeNode(pathA[i-1]);
        }

        return  new TreeNode(pathA[m-1]);
    }
    List<int> pathFromRoot(TreeNode root,TreeNode target){
        List<int> res = new List<int>();
        void DFS(TreeNode node,List<int> path){
            if(node ==null) return;
            path.Add(node.val);
            if (node.val == target.val){
                res = path;
            }
            if(target.val > node.val) DFS(node.right,path);
            if(target.val < node.val) DFS(node.left,path);
        }
        DFS(root,new List<int>());
        return res;
    }
}