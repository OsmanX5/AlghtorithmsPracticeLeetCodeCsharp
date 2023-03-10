public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int n = nums.Length;
        HashSet<int> numbers = new HashSet<int>(nums);
        int res=0;
        for(int i=1;i<n-1;i++){
           if(numbers.Contains(nums[i]+diff) && numbers.Contains(nums[i]-diff)){
               res+=1;
           }
        }
        return res;
    }
}