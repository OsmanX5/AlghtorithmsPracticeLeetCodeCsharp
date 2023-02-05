public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int n = nums.Length;
        int l=0;
        int r = n-1;
        while(l<r-1){
            int mid = l+ (r-l)/2;
            if(nums[mid] == target) return mid;
            if (nums[mid] <target) l= mid;
            else r = mid;
        }
        Console.WriteLine($"r ={r} l= {l}");
        if(nums[r]<target) return r+1;
        if(nums[l]>=target) return l;
        return r;
    }
}