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
    public IList<int> Postorder(Node root) {
        IList<int> res = new List<int>();
        
        void DFS(Node node){
            if(node ==null) return;  
            foreach(var nextNode in node.children) DFS(nextNode);
            res.Add(node.val);
        }
        DFS(root);
        return res;
    }
}