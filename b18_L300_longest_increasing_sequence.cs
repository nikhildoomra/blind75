public class Solution {
    public int LengthOfLIS(int[] nums) {
        // create array with 1 as default value
        int[] dp = Enumerable.Repeat<int>(1, nums.Length).ToArray(); 
        int max = 1;
        for(int i = 1;i < nums.Length; i++) {
            for(int j = 0; j < i; j++) {
                if(nums[j] < nums[i]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            max = Math.Max(dp[i], max);
        }
        return max;
    }
}
