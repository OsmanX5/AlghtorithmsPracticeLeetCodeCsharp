public class Solution {
    
    private string[] strings;
    private HashSet<string> visited = new HashSet<string>();
    
    public int NumSimilarGroups(string[] strs) {
        strings = strs;
        var count = 0;
        
        foreach (var str in strs) {
            if (visited.Contains(str)) {
                continue;
            }
            DFS(str);
            count++;
        }
        
        return count;
    }
    private void DFS(string A) {
        visited.Add(A);
        foreach (var B in strings) {
            if (visited.Contains(B)) {
                continue;
            }
            if (IsSimilar(A, B)) {
                DFS(B);
            }
        }
    }
    
    private bool IsSimilar(string A, string B) {
        int N = A.Length;
        var diff = 0;
        
        for (var i = 0; i < N; i++) {
            if (A[i] != B[i]) {
                diff++;
            }
        }
        
        return diff <= 2;
    }
    
}