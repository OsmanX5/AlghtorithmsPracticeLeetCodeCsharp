public class Solution {
    public int MinimizeArrayValue(int[] nums) {
        long res = 0, sum = 0;
                
        for (int i = 0; i < nums.Length; ++i) {
            sum += nums[i];
            res = Math.Max(res, (sum + i) / (i + 1));
        }
        
        return (int)res;
    }
}