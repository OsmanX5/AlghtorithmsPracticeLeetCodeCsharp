public class Solution {
    public int MinPathSum(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int[,] dp = new int[n,m];
        int SumTo(int i,int j){
            if(dp[i,j]!=0)
                return dp[i,j];
            int res = grid[i][j];
            if(i==0 && j==0) 
                res +=0 ;
            else if(i==0) 
                res += SumTo(i,j-1);
            else if(j==0) 
                res += SumTo(i-1,j);
            else
                res += Math.Min(SumTo(i-1,j), SumTo(i,j-1));
            dp[i,j] =res;
            return dp[i,j];
        }
        return SumTo(n-1,m-1);
        
    }
}