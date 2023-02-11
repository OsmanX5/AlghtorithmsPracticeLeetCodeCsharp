/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
        if(root==null)return 0;
        int max =0;
        void DFS(Node node,int depth){
            if(node ==null) return;
            Console.WriteLine($"visit {node.val} with depth{depth}");
            if(depth>max)max = depth;
            foreach(var nextNode in node.children) DFS(nextNode,depth+1);
        }
        DFS(root,1);
        return max;
    }
    
}