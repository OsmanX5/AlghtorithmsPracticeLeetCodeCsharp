public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int res =0;
        int cx,cy,tx,ty;
        int n= points.Length;
        (cx,cy) = (points[0][0],points[0][1]);
        for(int i=1;i<n;i++){
            int[] nextPoint = points[i];
            (tx,ty) =(nextPoint[0],nextPoint[1]);
            int difX = Math.Abs(tx-cx);
            int difY = Math.Abs(ty-cy);
            res+=Math.Max(difX,difY);
            (cx,cy) = (tx,ty);
        }
        
        return res;
    }
}