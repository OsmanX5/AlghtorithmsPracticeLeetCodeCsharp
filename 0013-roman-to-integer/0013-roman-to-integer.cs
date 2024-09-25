public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int val =dict[s[0]];
        int n = s.Length;
        for(int i=1;i<n;i++){
            int current = dict[s[i]];
            int last = dict[s[i-1]];
            if(last < current)
                val-= 2*last;
            val += current;

        }
        return val;
    }
}