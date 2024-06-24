public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length < 2) return 0;

        int left = 0;
        int right = 1;
        var currentMaxProfit = 0;

        while(left < right && right < prices.Length) {
            var currentProfit = prices[right] - prices[left];

            if(currentProfit < 0) {
                left = right;
                right = right + 1;
            } else {
                currentMaxProfit = Math.Max(currentMaxProfit, currentProfit);
                right = right + 1;
            }
        }
        return currentMaxProfit;
    }
}
