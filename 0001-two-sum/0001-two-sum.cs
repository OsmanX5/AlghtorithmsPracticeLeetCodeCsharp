public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        for(int i=0;i<n-1;i++){
            for(int j=i+1;j<n;j++)
                if(nums[i]+nums[j] == target) return new int[2]{i,j};
        }
        return new int[2];
    }
}