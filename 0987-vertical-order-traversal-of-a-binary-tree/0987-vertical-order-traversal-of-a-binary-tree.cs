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
   List<Tuple<int,int,int>> all = new();
    
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
         IList<IList<int>>res = new List<IList<int>>();
        Traversal(root,0,0);
        var sorted = all.OrderBy(x =>x.Item3).ThenBy(x=>x.Item2).ThenBy(x=>x.Item1).GroupBy(x => x.Item3);
        foreach(var col in sorted){
            List<int> temp = new();
            foreach(var x in col){
                //Console.Write(x.Item1);
                temp.Add(x.Item1);
            }
            res.Add(temp);
            //Console.WriteLine();
        }
        return res;
    }
    
    public void Traversal (TreeNode node,int r,int c){
        if (node==null) return;
        all.Add(new Tuple<int,int,int> (node.val,r,c));
        Traversal(node.left , r+1,c-1);
        Traversal(node.right , r+1,c+1);
    }
}