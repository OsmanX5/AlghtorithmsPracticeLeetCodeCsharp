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
public class BSTIterator {
    List<int> SortedNumers;
    int Count;
    int next;
    void InOrder(TreeNode node){
        if(node ==null) return;
        InOrder(node.left);
        SortedNumers.Add(node.val);
        InOrder(node.right);
        
    }
    public BSTIterator(TreeNode root) {
        SortedNumers = new();
        InOrder(root);
        Count = SortedNumers.Count();
        next=0;
    }
    
    public int Next() =>SortedNumers[next++];
    public bool HasNext() => next<Count;
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */