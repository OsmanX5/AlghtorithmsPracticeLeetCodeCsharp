public class Solution {
    public long MinimumTime(int[] time, int totalTrips) {
        long l =1;
        long r = (long)time.Min() * (long)totalTrips;
        while(l<r){
            long nowTime = l + (r-l)/2;
            
            long tripsOnTime = GetTrips(time,nowTime);
            if(tripsOnTime >= totalTrips )r = nowTime;
            if(tripsOnTime <  totalTrips)l = nowTime+1;
            
        }
        return r;
    }
    public long GetTrips(int[] trips,long time){
        long total =0;
        foreach(int trip in trips) total+= (long)(time/trip);
        return total;
    }
}