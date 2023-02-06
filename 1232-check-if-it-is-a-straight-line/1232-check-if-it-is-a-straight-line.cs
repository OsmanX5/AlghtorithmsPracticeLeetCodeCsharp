public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        float pastSlope =0;
        int[] p1;
        int[] p2;
        int n = coordinates.Length;
        for(int i=0;i<n-1;i++){
            p1 = coordinates[i];
            p2 = coordinates[i+1];
            float nowSlope =Slope(p1,p2);
            Console.WriteLine($"p1 = ({p1[0]},{p1[1]}) p2 = ({p2[0]},{p2[1]}) slope = {nowSlope}");
            if(i!=0)
            if (nowSlope!=pastSlope) return false;
            pastSlope = nowSlope;
        }
        return true;
    }
    float Slope(int[] p1,int[] p2){
        float yDif =  p2[1]-p1[1];
        float xDif = p2[0]-p1[0];
        if (xDif ==0) return int.MaxValue;
        return yDif/xDif;
    }
}