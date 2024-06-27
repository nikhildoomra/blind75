public class Solution {
    public int MaxProduct(int[] nums) {
        double maxProduct = nums[0];
        double minProduct = nums[0];
        double result = nums[0];

        for(int i = 1; i < nums.Length; i++) {
            var temp = minProduct;
            minProduct = Math.Min(nums[i], Math.Min(maxProduct * nums[i], temp * nums[i]));
            maxProduct = Math.Max(nums[i], Math.Max(maxProduct * nums[i], temp * nums[i]));

            result = Math.Max(result, maxProduct);
        }

        return (int)result;
    }
}
