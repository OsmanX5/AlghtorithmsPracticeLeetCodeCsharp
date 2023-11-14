class Solution {
    public int CountPalindromicSubsequence(String s) {
        int[] first = new int[26];
        int[] last = new int[26];
        Array.Fill(first, -1);
        
        for (int i = 0; i < s.Length; i++) {
            int curr = s[i] - 'a';
            if (first[curr] == - 1) {
                first[curr] = i;
            }
            
            last[curr] = i;
        }
        
        int ans = 0;
        for (int i = 0; i < 26; i++) {
            if (first[i] == -1) {
                continue;
            }
            
            HashSet<char> between = new HashSet<char>();
            for (int j = first[i] + 1; j < last[i]; j++) {
                between.Add(s[j]);
            }
            
            ans += between.Count();
        }
        
        return ans;
    }
}