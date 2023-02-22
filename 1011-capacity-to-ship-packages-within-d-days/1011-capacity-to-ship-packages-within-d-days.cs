public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = 0;
        int r = 0;
        for(int i=0;i<weights.Length;i++){
            if(weights[i]>l) l =weights[i];
            r+=weights[i];
        }
        while(l<r){
            int mid = l+(r-l)/2;
            int d = GetDays(weights,mid);
           // Console.WriteLine($"l ={l} , mid = {mid}  r ={r} , days ={d}");
            if(d<=days) r = mid;
            else l+=1;
        }
        return l;
        
    }
    int GetDays(int[] nums,int maxWeight){
        int days =1;
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            if(sum + nums[i]<=maxWeight)
                sum+=nums[i];
            else{
                days++;
                sum =nums[i];
            }
        }
        return days;
    }
}