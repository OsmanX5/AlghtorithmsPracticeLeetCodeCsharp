public class Solution {
    public int MinReorder(int n, int[][] connections) {
        GraphNode[] nodes = new GraphNode[n];
        for(int i = 0; i < n; i++) 
            nodes[i] = new GraphNode(i);
        foreach (int[] connection in connections)
        {
            int from = connection[0];
            int to = connection[1];
            nodes[from].OutNodes.Add(to);
            nodes[to].InNodes.Add(from);
        }

        Queue<GraphNode> qu = new Queue<GraphNode> ();
        qu.Enqueue(nodes[0]);
        bool[] visited = new bool[n];
        int res = 0;
        while(qu.Count > 0)
        {
            GraphNode current = qu.Dequeue();
            visited[current.val] = true;
            foreach(int x in current.InNodes)
                if (!visited[x])
                    qu.Enqueue(nodes[x]);
            foreach (int x in current.OutNodes)
            {
                if (visited[x]) continue;
                res++;
                nodes[x].SwitchFromInToOut(current.val);
                qu.Enqueue(nodes[x]);   
            }
        }
        return res;
    }
}
class GraphNode
{
    public int val;
    public List<int> InNodes= new List<int>();
    public List<int> OutNodes= new List<int>();
    public GraphNode(int val)=>this.val = val;
    public void SwitchFromInToOut(int x)
    {
        InNodes.Remove(x);
        OutNodes.Add(x);
    }

}