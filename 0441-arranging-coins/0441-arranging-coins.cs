public class Solution {
    public int ArrangeCoins(int n) {
        if(n<=1) return n;
        int row=1;
        int remain = n;
        while(remain > 0){
            if(row>remain) return row-1;
            remain-=row;
            row+=1;
        }
        return row-1;
    }
}