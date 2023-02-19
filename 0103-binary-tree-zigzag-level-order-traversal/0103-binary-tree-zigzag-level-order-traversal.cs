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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>(); 
        if(root==null)return res;
        Queue<TreeNode> BFS = new Queue<TreeNode>();
        
        BFS.Enqueue(root);
        bool inverseDirection = false;
        int levelCount =1;
        while(BFS.Count>0){
            List<int> level = new List<int>();
            int nextLevelCount=0;
            for(int i=0;i<levelCount;i++){
                TreeNode now = BFS.Dequeue();
                level.Add(now.val);
                if(now.left!=null){
                    BFS.Enqueue(now.left);
                    nextLevelCount+=1;
                }
                if(now.right!=null){
                    BFS.Enqueue(now.right);
                    nextLevelCount+=1;
                }
            }
            if(inverseDirection) level.Reverse();
            res.Add(level);
            levelCount = nextLevelCount;
            inverseDirection = !inverseDirection;
        }
        return res;
    }
}