public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1;
        int r=piles.Max();
        while(l<r){
            int speed = l + (r-l)/2;
            
            int currentHours = HouresNeededToEat(piles,speed);
            if(currentHours>h) l= speed+1;
            else r= speed;
        }
        return r;
    }
    int HouresNeededToEat(int[] piles,int speed) {
        return piles.Select(x=>x%speed==0? x/speed: (x/speed)+1 ).Sum();
    }
}