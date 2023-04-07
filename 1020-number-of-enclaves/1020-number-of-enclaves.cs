public class Solution {
    public int NumEnclaves(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        bool[,] visited = new bool[n,m];
        int Ones =0;
        for(int i=0;i<n;i++){
            for(int j=0 ;j<m;j++){
                if(grid[i][j] ==1) Ones++;
                if(IsOneAtEdge(i,j)) 
                    Spread(i,j);
            }
        }
        void Spread(int i,int j){
            if(i<0 || i>=n || j<0 || j>=m) return;
            if(visited[i,j] || grid[i][j] ==0) return;
            if(i<0 || i>=n || j<0 || j>=m) return;
            visited[i,j] = true;
            Ones-=1;
            Spread(i+1,j);
            Spread(i-1,j);
            Spread(i,j+1);
            Spread(i,j-1);
        }
        bool IsOneAtEdge(int i,int j) => (grid[i][j] ==1)&&(i==0 || i==n-1 || j==0 || j ==m-1 );
        return Ones;
    }
    
}