public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = Int32.MaxValue;
        for(int sellPrice = 0; sellPrice < prices.Length; ++sellPrice)
        {
            if(prices[sellPrice] < minPrice) 
                minPrice = prices[sellPrice];
            if(prices[sellPrice] - minPrice > maxProfit) 
                maxProfit = prices[sellPrice] - minPrice;
        }
        return maxProfit;
    }
}
