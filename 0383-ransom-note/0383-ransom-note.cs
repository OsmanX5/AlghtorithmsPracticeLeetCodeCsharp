public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] ransomNoteChars = new int[26];
        int[] magazineChars = new int[26];
        foreach(char c in ransomNote)ransomNoteChars[c - 'a']++;
        foreach(char c in magazine)magazineChars[c-'a']++;
        for(int i=0;i<26;i++){
            if(magazineChars[i] < ransomNoteChars[i]) return false;
        }
        return true;
    }
}