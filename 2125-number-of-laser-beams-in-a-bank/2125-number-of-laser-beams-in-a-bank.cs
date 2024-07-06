public class Solution {
    public int NumberOfBeams(string[] bank) {
        int[] devices = bank.Select(row => row.Where(c => c == '1').Count()).Where(x => x!=0 ).ToArray();
        return devices.Zip(devices.Skip(1), (num1 , num2) => num1 * num2 ).Sum();
    }
}