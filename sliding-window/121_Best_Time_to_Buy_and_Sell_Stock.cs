public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProf = 0;
        int cheapestSeen = prices[0]; 
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < cheapestSeen){
                cheapestSeen = prices[i];
            }
            if((prices[i] - cheapestSeen) > maxProf){
                maxProf = prices[i] - cheapestSeen;
            }
        }
        return maxProf;
    }
}
