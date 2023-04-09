public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        var AllNodes = new Dictionary<int, Node>();
		int n = colors.Length;

		// Create all graph nodes
		for (int i = 0; i < n; i++)
		{
			AllNodes[i] = new Node(i, colors[i]);
		}

		// Make the connections
		foreach (var edge in edges)
		{
			Node a = AllNodes[edge[0]];
			Node b = AllNodes[edge[1]];
			if (a.id == b.id) return -1;
            if(b.OutNodes.Contains(a)) return -1;
			a.OutNodes.Add(b);
			b.InNodes.Add(a);
		}

		

		// Find start points
		var StartPointsIds = new HashSet<int>();
		foreach (var node in AllNodes)
		{
			if (node.Value.InNodes.Count == 0)
			{
				StartPointsIds.Add(node.Key);
			}
		}

		// DFS to compute colors
		bool[] visited = new bool[n];
		HashSet<int> recursionStack = new HashSet<int>();
		bool hasCycle = false;

		void DFS(Node node)
		{
			if (recursionStack.Contains(node.id))
			{
				hasCycle = true;
				return;
			}
			if (visited[node.id])return;
			recursionStack.Add(node.id);
			foreach (Node next in node.OutNodes)
				DFS(next);
			foreach (Node next in node.OutNodes)
				node.AddColors(next.ColorsOfMeAndAfter);
			node.ColorsOfMeAndAfter[node.color -'a'] += 1;
			visited[node.id] = true;
			recursionStack.Remove(node.id);
		}
        if (StartPointsIds.Count == 0) return -1;
		foreach (int startPoint in StartPointsIds)
		{
			DFS(AllNodes[startPoint]);
			if (hasCycle)
			return -1;
		}

		int res = 0;
		foreach (int start in StartPointsIds)
		res = Math.Max(res, AllNodes[start].ColorsOfMeAndAfter.Max());

		return res;
    }
}
class Node
{
	public int id;
	public char color;
	public List<Node> InNodes;
	public List<Node> OutNodes;
	public int[] ColorsOfMeAndAfter;
	public Node(int id, char c)
	{
		this.id = id;
		this.color = c;
		InNodes = new List<Node>();
		OutNodes = new List<Node>();
		ColorsOfMeAndAfter = new int[26];
	}

	public void AddColors(int[] colors)
	{
		for (int i = 0; i < 26; i++)
		{
			ColorsOfMeAndAfter[i] = Math.Max(colors[i], ColorsOfMeAndAfter[i]);
		}	
	}

	public override string ToString()
	{
		string s = "";
		s += $"Id: {id} color: {color} \n";
		s += "In Nodes Ids: [ ";
		foreach (var node in InNodes) s += $" {node.id} ";
		s += "] \n ";
		s += "Out Nodes Ids: [ ";
		foreach (var node in OutNodes) s += $" {node.id} ";
		s += "]\n";
		s += "Colors: \n";
		for (int i = 0; i < 26; i++) if(ColorsOfMeAndAfter[i]!=0) s += $" {(char)(i+'a')} ";
		s += "\n";
		for (int i = 0; i < 26; i++) if (ColorsOfMeAndAfter[i] != 0) s += $" {ColorsOfMeAndAfter[i]} ";
		s += " \n ";
		return s;

	}
}
