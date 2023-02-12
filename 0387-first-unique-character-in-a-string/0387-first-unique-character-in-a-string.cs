public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> repation = new();
        for(char i ='a' ;i<='z';i++)repation[i]=0;
        for(int i=0;i<s.Length;i++)repation[s[i]]+=1;
        List<char> notRepated = new();
        foreach(var pair in repation) if(pair.Value==1)notRepated.Add(pair.Key);
        for(int i=0;i<s.Length;i++) if(notRepated.Contains(s[i])) return i;
        return -1;
    }
}