public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        int res=0;
        foreach(string word in words){
            if(IsSubSequance(s,word)) res+=1;
        }
        return res;
    }
    public bool IsSubSequance(string s,string word){
        if(word.Length>s.Length) return false;
        int p =0;
        foreach(char c in word){
            while(p<s.Length){
                if(s[p] == c) break;
                p++;
            }
            p++;
            if(p>s.Length) return false;
        }
        return true;
    }
}