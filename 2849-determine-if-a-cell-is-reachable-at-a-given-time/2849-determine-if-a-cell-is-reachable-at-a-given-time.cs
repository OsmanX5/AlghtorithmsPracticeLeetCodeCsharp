public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        int dx = Math.Abs(fx-sx);
        int dy = Math.Abs(fy-sy);
        int mint = Math.Max(dx,dy);
        Console.WriteLine($"Mint = {mint} , dx ={dx} , dy= {dy}");
        if(dx==0 && dy ==0 && t==1) return false;
        return t>=mint;
        
    }
}