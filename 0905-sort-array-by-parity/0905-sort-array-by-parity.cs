public class Solution {
    public int[] SortArrayByParity(int[] nums) => nums.OrderBy( x =>x%2!=0 ).ToArray();
    
}