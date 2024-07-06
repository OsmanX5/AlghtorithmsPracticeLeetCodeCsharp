public class Solution {
    public int NumberOfBeams(string[] bank) {
        var devices = bank.Select(row => row.Where(c => c == '1').Count()).Where(x => x!=0 );
        return devices.Zip(devices.Skip(1), (num1 , num2) => num1 * num2 ).Sum();
    }
}