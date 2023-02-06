public class Solution {
    public bool IsPerfectSquare(int num) {
        long l=1;
        long r = num;
        while(l<r-1){
            long mid = l+(r-l)/2;
            Console.WriteLine($"l = {l} r = {r} mid = {mid}");
            if(mid *mid == num) return true;
            if(mid*mid <num) l = mid;
            else r=mid;
        }
        if(l*l==num || r*r ==num) return true;
        return false;
    }
}