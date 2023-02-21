public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int n =nums.Length;
        if (n==1) return nums[0];
        if(nums[0]!=nums[1])return nums[0];
        
        int l=0;
        int r=n-1;
        
        while(l<=r){
            int mid = l + (r-l)/2;
            if(mid>=n-1)break;
            if(nums[mid]!=nums[mid-1] && nums[mid]!= nums[mid+1])
                return nums[mid];
            if(isEven(mid) && nums[mid] == nums[mid+1] || !isEven(mid) &&nums[mid] == nums[mid-1])
                l=mid+1;
            else
                r=mid;
            
        }
        return nums[n-1];
    }
    bool isEven(int x)=>x%2==0;
}