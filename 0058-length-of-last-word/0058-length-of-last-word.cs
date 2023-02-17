public class Solution {
    public int LengthOfLastWord(string s) {
        return s.Split(" ").Where(x=> x.Length>=1)
            .ToArray().Last().Length;
    }
}