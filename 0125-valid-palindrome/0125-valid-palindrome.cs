public class Solution {
    public bool IsPalindrome(string s) {
        var s2 = "";
        foreach(char c in s)
            if('A'<=c&&c<='Z') s2+=Char.ToLower(c);
            else if('a'<=c&&c<='z') s2+=c;
            else if('0'<=c&&c<='9') s2+=c;
        int n =s2.Length;
        Console.WriteLine(s2);
        for(int i=0;i<n/2;i++) 
            if(s2[i]!=s2[n-1-i])return false;
        return true;
    }
}