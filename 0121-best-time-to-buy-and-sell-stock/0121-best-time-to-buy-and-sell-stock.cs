public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min =prices[0];
        int max=prices[0];
        for(int i=1;i<prices.Length;i++){
            int now = prices[i];
            if(now<min){
                // new profit exchange
                max = now;
                min = now;
            }
            if(now> max){
                max = now;
                int profit = max - min;
                maxProfit = Math.Max(maxProfit,profit);
            }
        }
        return maxProfit;
    }
}