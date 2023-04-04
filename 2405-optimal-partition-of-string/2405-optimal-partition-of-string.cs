public class Solution {
    public int PartitionString(string s) {
        int res =1;
        HashSet<char> found = new HashSet<char>();
        foreach(char c in s){
            if(found.Contains(c))
            {
                found.Clear();        
                res++;
            }
            found.Add(c);
        }
        return res;
    }
}