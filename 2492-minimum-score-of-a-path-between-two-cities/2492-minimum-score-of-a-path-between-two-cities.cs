public class Solution {
    public int MinScore(int n, int[][] roads) {
        UnionFind UF = new UnionFind(n+1);
        foreach(int[] road in roads){
            int a = road[0];
            int b = road[1];
            int w = road[2];
            UF.Union(a,b);
        }
        int res =int.MaxValue;
        foreach(int[] road in roads){
            int a = road[0];
            int b = road[1];
            int w = road[2];
            if(UF.IsConnected(1,a))
                res = Math.Min(w,res);
        }
        
        return res;
    }
}
public class UnionFind
    {
        private int[] root;
        private int[] rank;
        
        Dictionary<int , HashSet<int>> Sets;

        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];
            Sets = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = 1;
                Sets.Add(i,new HashSet<int>() { i});
            }
        }

        public int find(int x)
        {
            while (x != root[x])
            {
                x = root[x];
            }
            return x;
        }

        public void Union(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])
                {
                    root[rootY] = rootX;
                    Sets[rootX].UnionWith(Sets[rootY]);
                    Sets.Remove(rootY);
                }
                else if (rank[rootX] < rank[rootY])
                {
                    root[rootX] = rootY;
                    Sets[rootY].UnionWith(Sets[rootX]);
                    Sets.Remove(rootX);
                }
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                    Sets[rootX].UnionWith(Sets[rootY]);
                    Sets.Remove(rootY);
                }
            }
        }

        public bool IsConnected(int x, int y)
        {
            return find(x) == find(y);
        }

        public HashSet<int> GetSet(int x)
        {
            return Sets[find(x)];
        }
        public List<HashSet<int>> GetSets()
        {
            List<HashSet<int>> res = new List<HashSet<int>>();
            foreach(var pair in Sets) res.Add(pair.Value);
            return res;
        }
        public int SetsCount() => Sets.Count;
        public override string ToString()
        {
            string  res = "";
            foreach(var set in Sets)
            {
                res += $"\n set {set.Key}: [";
                foreach (int x in set.Value) res += " " + x.ToString() +" ";
                res += " ]";
            }
            return res;
        }
    }