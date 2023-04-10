public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int n = nums.Length;
        List<int> res= new List<int>();
        for(int i =0;i<n;i++){
            if (nums[i]%2==0) res.Insert(0,nums[i]);
            else res.Add(nums[i]);
        }
        return res.ToArray();
    }
}