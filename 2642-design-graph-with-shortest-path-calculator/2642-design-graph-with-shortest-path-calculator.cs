
public class Graph {

    private Dictionary<int, List<int[]>> adjacencyList;

    public Graph(int n, int[][] edges) {
        adjacencyList = new Dictionary<int, List<int[]>>();
        foreach (var edge in edges) {
            int from = edge[0];
            int to = edge[1];
            int cost = edge[2];
            if (!adjacencyList.ContainsKey(from)) {
                adjacencyList[from] = new List<int[]>();
            }
            adjacencyList[from].Add(new int[] { to, cost });
        }
    }
    
    public void AddEdge(int[] edge) {
        int from = edge[0];
        int to = edge[1];
        int cost = edge[2];
        if (!adjacencyList.ContainsKey(from)) {
            adjacencyList[from] = new List<int[]>();
        }
        adjacencyList[from].Add(new int[] { to, cost });
    }
    
    public int ShortestPath(int node1, int node2) {
        SortedSet<(int, int)> minHeap = new SortedSet<(int, int)> {(0, node1)};
        Dictionary<int, int> distances = new Dictionary<int, int> {{node1, 0}};

        while (minHeap.Count > 0) {
            var (currentDistance, currentNode) = minHeap.Min;
            minHeap.Remove(minHeap.Min);

            if (currentNode == node2) {
                return currentDistance;
            }

            if (currentDistance > distances[currentNode]) {
                continue;
            }

            if (adjacencyList.ContainsKey(currentNode)) {
                foreach (var neighbor in adjacencyList[currentNode]) {
                    int neighborNode = neighbor[0];
                    int neighborDistance = neighbor[1];
                    int newDistance = currentDistance + neighborDistance;

                    if (!distances.ContainsKey(neighborNode) || newDistance < distances[neighborNode]) {
                        distances[neighborNode] = newDistance;
                        minHeap.Add((newDistance, neighborNode));
                    }
                }
            }
        }

        return -1; // No path found
    }
}

/**
 * Your Graph object will be instantiated and called as such:
 * Graph obj = new Graph(n, edges);
 * obj.AddEdge(edge);
 * int param_2 = obj.ShortestPath(node1,node2);
 */
