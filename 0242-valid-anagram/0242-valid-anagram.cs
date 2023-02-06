public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] alpha1 = new int[26];
        int[] alpha2 = new int[26];
        foreach(char c in s) alpha1[c -'a'] +=1;
        foreach(char c in t) alpha2[c -'a'] +=1;
        for(int i =0;i<26;i++) if (alpha1[i]!=alpha2[i]) return false;
        return true;
    }
}