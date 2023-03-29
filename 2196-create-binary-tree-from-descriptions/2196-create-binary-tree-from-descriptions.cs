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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int,TreeNode> dict = new Dictionary<int,TreeNode>();
        HashSet<int> notRoot = new HashSet<int>();
        TreeNode root = null;
        foreach(int[] descrip in descriptions){
            int parentVal = descrip[0];
            int childVal = descrip[1];
            bool isLeft = descrip[2]==1;
            
            if (!dict.ContainsKey(parentVal))
                dict[parentVal] = new TreeNode(parentVal);
            if (!dict.ContainsKey(childVal))
                dict[childVal] = new TreeNode(childVal);
            
            TreeNode parent = dict[parentVal];
            TreeNode child = dict[childVal];
        
            if(isLeft)
                parent.left = child;
            else
                parent.right = child;
            
            notRoot.Add(child.val);
        }
        foreach(int node in dict.Keys){
            if(!notRoot.Contains(node))
                root = dict[node];
        }
        return root;
    }
}