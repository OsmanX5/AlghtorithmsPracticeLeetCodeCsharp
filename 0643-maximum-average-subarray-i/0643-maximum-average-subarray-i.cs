public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int n =nums.Length;
        int sum= nums[0..k].Sum();
        double avg = (double)(sum)/k;
        for(int i=k;i<n;i++){
            sum+= nums[i] - nums[i-k];
            avg = Math.Max(avg, (double)sum/k);
        }
        return avg;
    }
}