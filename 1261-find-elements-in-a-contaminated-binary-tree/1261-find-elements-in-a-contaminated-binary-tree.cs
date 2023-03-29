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
public class FindElements {
    TreeNode rt;
    public FindElements(TreeNode root) {
        void DFS(TreeNode node){
            if(node.left!=null){
                node.left.val = node.val *2 +1;
                DFS(node.left);
            }
            if(node.right!=null){
                node.right.val = node.val *2 +2;
                DFS(node.right);
            }        
        }
        rt = root;
        root.val=0;
        DFS(root);
    }
    
    public bool Find(int target) {
        Queue<TreeNode> BFS = new Queue<TreeNode>();
        BFS.Enqueue(rt);
        while(BFS.Count>0){
            TreeNode node = BFS.Dequeue();
            if(node.val == target)
                return true;
            if (node.left!=null) BFS.Enqueue(node.left);
            if (node.right!=null)BFS.Enqueue(node.right);
        }

        return false;
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */