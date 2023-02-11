public class Solution {
    public int CountNegatives(int[][] grid) {
        int res=0;
        int n =grid.Length;
        int m = grid[0].Length;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]<0) res++;
            }
        }
        return res;
    }
}