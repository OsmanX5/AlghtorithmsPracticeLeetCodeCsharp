public class Solution {
    public string ReverseWords(string s) => 
        String.Join(" ",s.Split(" ").Where(word => word.Length>0).Reverse());
    
}