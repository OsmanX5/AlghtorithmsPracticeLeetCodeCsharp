public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        int count =0;
        int n= nums.Length;
        long result =0;
        for(int i=0;i<n;){
            while(i<n&&nums[i]==0){
                count++;
                i++;
            }
            result+=sum(count);
            count =0;
            i++;
        }
        return result;
    }
    long sum(long x) => (x+x*x)/2;
}