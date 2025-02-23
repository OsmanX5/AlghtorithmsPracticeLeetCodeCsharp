public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n = word1.Length,
            m = word2.Length;
        
        char[] res = new char[n+m];
        bool first=true;
        int p1 =0,p2=0;
        for(int i=0;i<n+m;i++){
            res[i] =  first? word1[p1++] : word2[p2++];
            first = p1>=n ? false : p2>=m ? true : !first;
        }

        return new String(res);
    }
}