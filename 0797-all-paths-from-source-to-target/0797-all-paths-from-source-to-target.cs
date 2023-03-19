public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        int n = graph.Length;
        List<int>[] adjList = new List<int>[n];
        for(int i=0;i<n;i++){
            adjList[i] = new List<int>();
            foreach(int x in graph[i])
                adjList[i].Add(x);
        }
        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < adjList.Length; i++)
        {
            Console.Write($"adjList[{i}]: ");
            for (int j = 0; j < adjList[i].Count; j++)
            {
                Console.Write($"{adjList[i][j]} ");
            }
            Console.WriteLine();
        }
        void DFS(int node,List<int> path){
            List<int> newPath = new List<int>(path);
            newPath.Add(node);
            if(node == n-1){
                res.Add(newPath);
                return;
            }
            foreach(int nxt in adjList[node]){
                DFS(nxt,newPath);
            }
        }
        DFS(0,new List<int>());
        return res;
    }
}