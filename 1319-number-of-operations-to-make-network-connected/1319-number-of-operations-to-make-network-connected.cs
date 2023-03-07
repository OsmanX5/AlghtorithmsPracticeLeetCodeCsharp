public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        UnionFind UF = new UnionFind(n);
        int m = connections.Length;
        for(int i=0; i < m; i++)
        {
            UF.Union(connections[i][0], connections[i][1]);
        }
        int numberOFNeedeWires = UF.SetsCount()-1;
        int numberOfExtraWires = UF.extra;
        Console.WriteLine(numberOFNeedeWires);
        Console.WriteLine(numberOfExtraWires);
        if(numberOFNeedeWires>numberOfExtraWires)return-1;
        return numberOFNeedeWires;
    }
}
    public class UnionFind
    {
        private int[] root;
        private int[] rank;
        Dictionary<int , HashSet<int>> Sets;
        public int extra;
        public UnionFind(int size)
        {
            extra=0;
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
            else{
                extra+=1;
            }
        }

        public bool connected(int x, int y)
        {
            return find(x) == find(y);
        }

        public HashSet<int> GetSet(int x)
        {
            return Sets[find(x)];
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