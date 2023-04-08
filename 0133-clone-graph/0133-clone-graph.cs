/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    
    public Node CloneGraph(Node node) {
        if(node == null)return null;
        var CloneMap = new Dictionary<Node,Node>();
        var cloned = new HashSet<int>();
        //Clone
        void Clone(Node n){
            if(cloned.Contains(n.val))return;
            CloneMap.Add(n , new Node(n.val));
            Console.WriteLine($"cloning {n.val}");
            cloned.Add(n.val) ;
            foreach(var next in n.neighbors)
                Clone(next);
        }
        Clone(node);
         var visited = new HashSet<int>();
        //Connecting
        void DFS(Node n){
            if(visited.Contains(n.val)) return;
            visited.Add(n.val);
            Console.WriteLine($"visiting {n.val}");
            foreach(var next in n.neighbors){
                Connect(CloneMap[n],CloneMap[next]);
                DFS(next);    
            }
        }
        void Connect(Node a,Node b){
            if(!a.neighbors.Contains(b))
                a.neighbors.Add(b);
            if(!b.neighbors.Contains(a))
                b.neighbors.Add(a);
            
        }
        DFS(node);
        return CloneMap[node];
        
        
    }
}