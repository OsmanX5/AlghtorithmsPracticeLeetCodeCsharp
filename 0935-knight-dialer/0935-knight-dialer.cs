public class Solution {
private const int mod = 1_000_000_007;
    
    public int KnightDialer(int n) {
        if (n <= 0)
            return 0;
        
        if (n == 1)
            return 10;
        
        long[] current = Enumerable
            .Repeat(1L, 10)
            .ToArray();
        
        long[] next = new long[current.Length];
        
        current[5] = 0;
        
        for (int i = 1; i < n; ++i) {
            next[0] = current[4] + current[6];
            next[1] = current[6] + current[8];
            next[2] = current[7] + current[9];
            next[3] = current[4] + current[8];
            next[4] = current[0] + current[3] + current[9];
            next[6] = current[0] + current[1] + current[7];
            next[7] = current[2] + current[6];
            next[8] = current[1] + current[3];
            next[9] = current[2] + current[4];
            
            for (int j = 0; j < next.Length; ++j)
                current[j] = next[j] % mod;
        }
        
        return (int)(current.Sum() % mod);
    }
}