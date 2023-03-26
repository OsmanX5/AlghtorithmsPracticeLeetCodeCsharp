public class Solution {
    public int LongestCycle(int[] edges) {
        int maxCycielLength = -1;
        int n = edges.Length;
        bool[] visited = new bool[n];
        
        Dictionary<int,int> Depth = new  Dictionary<int,int> ();

        
        int start,next;
        
       for(int i=0;i<n;i++)
        {
            start = i;
            if(visited[start]) continue;
            Depth = new  Dictionary<int,int> ();
            followPath(start,0);
        }
        void followPath(int start,int depth)
        {
            if (visited[start] )
            {
                if(!Depth.ContainsKey(start))return;
                if (Depth[start] < depth)
                {
                    int len = depth - Depth[start];
                    maxCycielLength = Math.Max(maxCycielLength, len);
                }
                return;
            }
            visited[start] = true;
            Depth[start] = depth;
            int next = edges[start];
            if (next == -1) return;
            followPath(next, depth + 1);
        }
        return maxCycielLength;
    }
}