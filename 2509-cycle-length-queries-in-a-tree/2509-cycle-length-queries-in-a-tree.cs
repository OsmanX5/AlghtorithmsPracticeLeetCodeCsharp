public class Solution {
    
    public int[] CycleLengthQueries(int n, int[][] queries) {
        int[] res = new int[queries.Length];
        for(int i=0;i<queries.Length;i++){
            int a = queries[i][0];
            int b= queries[i][1];
            int levela =  getLevel(a);
            //Console.WriteLine($"a = {a}  level => {levela}");
            
            int levelb = getLevel(b);
            //Console.WriteLine($"b = {b}  level => {levelb}");
            int lca = getLCA(a,b);
            //Console.WriteLine($"lca of {a} ,{b}  = {lca}");
            int length =levela +levelb -2*getLevel(lca)+1 ;
            
            res[i] = length;
            
        }
        return res;
        
    }
    public int getLevel(int x){
        int n =0;
        int levelMax = 1;
        while(levelMax<x){
            n+=1;
            levelMax = (int)Math.Pow(2,n+1)-1;
        }
        return n;
    }
    public List<int> getParentPath(int x){
        List<int> path = new();
        path.Add(x);
        int parent = getParent(x);
        while(parent >0){
            path.Add(parent);
            
            parent = getParent(parent);
        }
        //Console.Write($"path of {x} : ");
        ///foreach(int i in path)Console.Write($" => {i}");
        //Console.WriteLine();
        return path;
        
    }
    public int getParent(int x){
        if (x%2==0) return x/2;
        return (x-1)/2;
    }
    public int getLCA(int a,int b){
         List<int> pathA = getParentPath(a);
         List<int> pathB = getParentPath(b);

         int n= pathA.Count();
         int m =pathB.Count();
         int p1=n-1;
         int p2=m-1;
        while(p1>=0 && p2>=0){
            
            if (pathA[p1] != pathB[p2]){
                return pathA[p1+1];
            }
            if(p1==0) return pathA[p1];
            if(p2==0) return pathB[p2];
            
            p1--;
            p2--;
        }
        return pathB[m-1];
    }

}
