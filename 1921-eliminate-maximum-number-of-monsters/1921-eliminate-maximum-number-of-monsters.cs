public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        int n = dist.Length;
        int[] time = new int[n];
        for(int i=0;i<n;i++) time[i] = (int)Math.Ceiling((double)dist[i]/(double)speed[i]);
        Array.Sort(time);
        int elepsedTime=1;
        for(int i=1;i<n;i++){
            if(time[i] <= elepsedTime ) 
                return elepsedTime;
            elepsedTime++;
        }
        return n;
    }
}