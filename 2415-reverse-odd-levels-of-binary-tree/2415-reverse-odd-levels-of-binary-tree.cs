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
    public TreeNode ReverseOddLevels(TreeNode root) {
        Queue<TreeNode> BFS = new Queue<TreeNode>();
        BFS.Enqueue(root);
        bool isOddLevel = false;
        int NodesCount= 0;
        List<TreeNode> OddLevel = new List<TreeNode>();
        int nextLevelCount =1;
        while(BFS.Count>0){

            
            TreeNode Current =BFS.Dequeue();
            NodesCount++;
            
            if(isOddLevel)OddLevel.Add(Current);
            
            if(Current.left!=null) BFS.Enqueue(Current.left);
            if(Current.right!=null) BFS.Enqueue(Current.right);
                        if(NodesCount ==  nextLevelCount){
                int n = OddLevel.Count;
                Console.WriteLine($"{NodesCount}   {isOddLevel}  {n}");
                for(int i=0;i<n/2;i++){
                    (OddLevel[i].val,OddLevel[n-1-i].val) = (OddLevel[n-1-i].val,OddLevel[i].val);
                }
                OddLevel = new List<TreeNode>();
                isOddLevel=!isOddLevel;
                nextLevelCount = 2*nextLevelCount;
                NodesCount=0;
            }
        }
        return root;
    }
    bool isPowerOfTwo(int n)
    {
 
        if (n == 0)
            return false;
 
        return (int)(Math.Ceiling(
                   (Math.Log(n) / Math.Log(2))))
            == (int)(Math.Floor(
                ((Math.Log(n) / Math.Log(2)))));
    }
    
}