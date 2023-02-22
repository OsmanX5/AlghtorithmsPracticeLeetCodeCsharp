public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = 0;
        int r = 0;
        int n=weights.Length;
        for(int i=0;i<n;i++){
            if(weights[i]>l) l =weights[i];
            r+=weights[i];
        }
        while(l<r){
            int mid = l+(r-l)/2;
            bool d = GetDays(weights,mid,days);
           // Console.WriteLine($"l ={l} , mid = {mid}  r ={r} , days ={d}");
            if(d) r = mid;
            else l+=1;
        }
        return l;
        
    }
    bool GetDays(int[] nums,int maxWeight,int daysCount){
        int days =1;
        int sum=0;
        int n= nums.Length;
        for(int i=0;i<n;i++){
            if(sum + nums[i]<=maxWeight)
                sum+=nums[i];
            else{
                days++;
                sum =nums[i];
            }
        }
        return days<=daysCount;
    }
}