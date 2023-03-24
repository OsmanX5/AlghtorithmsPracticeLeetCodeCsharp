public class Solution {
    public int MinReorder(int n, int[][] connections) {
        GraphNode[] nodes = new GraphNode[n];
        for(int i = 0; i < n; i++) nodes[i] = new GraphNode(i);
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
            //Console.WriteLine($"Curretn = {current.val}");
            foreach(int x in current.InNodes)
            {
                if (visited[x]) continue;
                qu.Enqueue(nodes[x]);
            }
            List<int> outNodes = new List<int>(current.OutNodes);
            foreach (int x in outNodes)
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
    public List<int> InNodes;
    public List<int> OutNodes;
    public GraphNode(int val)
    {
        this.val = val;
        InNodes = new List<int>();
        OutNodes = new List<int>();
    }
    public void SwitchFromInToOut(int x)
    {
        InNodes.Remove(x);
        OutNodes.Add(x);
    }

}