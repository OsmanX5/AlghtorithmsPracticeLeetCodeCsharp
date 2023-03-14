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
        Stack<TreeNode> DFS = new Stack<TreeNode>();
        DFS.Push(root);
        Dictionary<TreeNode,int> SumToNode = new Dictionary<TreeNode,int>();
        SumToNode.Add(root,root.val);
        while(DFS.Count>0){
            TreeNode CurrentNode = DFS.Pop();
            
            if(CurrentNode.left==null && CurrentNode.right==null){
                res += SumToNode[CurrentNode];
            }
            if (CurrentNode.right!=null){
                DFS.Push(CurrentNode.right);
                SumToNode[CurrentNode.right] = SumToNode[CurrentNode]*10 + CurrentNode.right.val;
            }
            if (CurrentNode.left!=null){
                DFS.Push(CurrentNode.left);
                SumToNode[CurrentNode.left] =  SumToNode[CurrentNode]*10 + CurrentNode.left.val;
            }
                
        }
        return res;
    }

}