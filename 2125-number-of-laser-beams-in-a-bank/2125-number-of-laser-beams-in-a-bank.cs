public class Solution {
    public int NumberOfBeams(string[] bank) {
        int res=0;
        int[] devices = bank.Select(row => row.Where(c => c == '1').Count()).Where(x => x!=0 ).ToArray();
        for (int i=0;i<devices.Length-1;i++)
            res += devices[i] *devices[i+1];
        return res;
    }
}