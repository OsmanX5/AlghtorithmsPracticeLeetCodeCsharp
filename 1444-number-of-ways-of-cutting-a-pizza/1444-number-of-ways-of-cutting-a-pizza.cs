public class Solution {
    public int Ways(string[] pizza, int k) {
        int rows = pizza.Length;
        int cols = pizza[0].Length;
        int[][] apples = new int[rows + 1][];
        
        for(int i=0;i<apples.Length;i++) 
            apples[i] = new int[cols + 1];
        
        int[][][] dp = new int[k][][];
        for(int i=0;i<dp.Length;i++)
        {
            dp[i] = new int[rows][];
            for(int j=0;j<dp[i].Length;j++)
                dp[i][j] = new int[cols];
        }
        for (int row = rows - 1; row >= 0; row--) {
            for (int col = cols - 1; col >= 0; col--) {
                apples[row][col] = (pizza[row][col] == 'A' ? 1 : 0) + apples[row + 1][col] + apples[row][col + 1]
                        - apples[row + 1][col + 1];
                dp[0][row][col] = apples[row][col] > 0 ? 1 : 0;
            }
        }
        int mod = 1000000007;
        for (int remain = 1; remain < k; remain++) {
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    for (int next_row = row + 1; next_row < rows; next_row++) {
                        if (apples[row][col] - apples[next_row][col] > 0) {
                            dp[remain][row][col] += dp[remain - 1][next_row][col];
                            dp[remain][row][col] %= mod;
                        }
                    }
                    for (int next_col = col + 1; next_col < cols; next_col++) {
                        if (apples[row][col] - apples[row][next_col] > 0) {
                            dp[remain][row][col] += dp[remain - 1][row][next_col];
                            dp[remain][row][col] %= mod;
                        }
                    }
                }
            }
        }
        return dp[k - 1][0][0];
    }
}