public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        for(int i=1;i<=n;i++){
            int grater = HowManyGraterThan(i,nums);
            //Console.WriteLine($"grater than {i} = {grater}");
            if (i ==grater ) return i;
        }
        return -1;
    }
    int HowManyGraterThan(int x,int[] nums){
        int n = nums.Length;
        int index =  nextGraterIndex(x,nums);
        //Console.WriteLine($"index of grater than  {x} = {index}");
        if(index == -1) return 0;
        return n-index;
    }
    int nextGraterIndex(int x, int[]nums){
        // Console.WriteLine($"BS OF{x}");
        int n = nums.Length;
        int l=0;
        int r = n-1;
        if(x>nums[r]) return -1;
        while(l<r){
            int mid = l + (r-l)/2;
            if(nums[mid] >= x)r = mid;
            else l =mid+1;
        }
       // Console.WriteLine($"L = {l} R = {r}");
        if(l != n && nums[l] >= x) return l;
        return l-1;
    }
}