public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int max = nums[0];
        int nowSum =0 ;
        for(int i=0;i<n;i++){
            nowSum += nums[i];
            max = (int)Math.Max(max,nowSum);
            if(nowSum <=0) nowSum=0;
        }
        return max;
    }
}