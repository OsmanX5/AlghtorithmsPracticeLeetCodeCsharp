public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        List<int> list = new();
        
        int i = 0, j = nums.Length - 1;
        
        while(i < j)
        {
            list.Add(nums[i] + nums[j]);
            i++;
            j--;
        }
        
        return list.Max();
    }
}