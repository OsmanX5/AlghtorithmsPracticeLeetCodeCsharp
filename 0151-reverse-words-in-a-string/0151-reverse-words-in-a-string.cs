public class Solution {
    public string ReverseWords(string s) {
        var splited = s.Split(" ").Where(word => word.Length>0).Reverse().ToArray();
        return String.Join(" ",splited);
    }
}