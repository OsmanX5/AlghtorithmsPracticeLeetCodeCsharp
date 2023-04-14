public class Solution {
    public int LongestPalindromeSubseq(string s) {
        int n = s.Length;
        int[,] dp = new int[n, n];
        int max = 1;
        for (int i = 0; i < n; i++) 
            dp[i,i] = 1;
        for(int end = 1; end < n; end++)
        {
            for(int start = 0; start <end; start++)
            {
                if (s[start] == s[end])
                {
                    dp[start,end] =dp[start+1, end-1] + 2;
                }
                else{
                    dp[start,end] = Math.Max(dp[start+1,end-1],dp[start,end-1]);
                }
                max = Math.Max(max, dp[start,end]);
            }
            for(int start=end-1;start>=0;start--)
                dp[start,end] = Math.Max(dp[start,end],dp[start+1,end]);
        }

        return max;
    }
    
}