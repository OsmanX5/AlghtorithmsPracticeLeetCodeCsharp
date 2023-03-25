public class Solution {
    public long CountPairs(int n, int[][] edges) {
        UnionFind UF = new UnionFind(n);
        foreach (var connection in edges)
        {
            int mn = Math.Min(connection[0], connection[1]);
            int mx= Math.Max(connection[0], connection[1]);
            UF.Union(mn,mx);
        }
        
        return UF.total;
    }
}
public class UnionFind
    {
        private int[] root;
        private int[] rank;
        Dictionary<int,int> setCount;
        public long total;
        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];
            setCount = new Dictionary<int,int>();
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = 1;
                setCount[i] =1;
            }
            long x = size-1;
            total = (long)((x*x+x)/2.0);
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
               // Console.WriteLine($"\ntotal = {total} - {setCount[rootX] * setCount[rootY]}");
                total-= setCount[rootX] * setCount[rootY];
                
                if (rank[rootX] > rank[rootY]){
                    root[rootY] = rootX;
                    setCount[rootX] +=setCount[rootY];
                    setCount.Remove(rootY);
                }
                else if (rank[rootX] < rank[rootY]){
                    root[rootX] = rootY;
                    setCount[rootY] +=setCount[rootX];
                    setCount.Remove(rootX);
                }
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                    setCount[rootX] +=setCount[rootY];
                    setCount.Remove(rootY);
                }
                /*Console.WriteLine($"\nconnecting {x}<>{y}");
                Console.WriteLine("root");
                foreach(int t in root)Console.Write($" {t} ");
                Console.WriteLine("\ncount");
                foreach(int t in setCount)Console.Write($" {t} ");*/
                
            }
        }
    }