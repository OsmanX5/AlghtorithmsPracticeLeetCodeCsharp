public class Solution {
    public int LengthOfLastWord(string s) {
        var x=  s.Split(" ").Where(x=> x.Length>=1).ToArray();
        return x[x.Length-1].Length;
    }
}