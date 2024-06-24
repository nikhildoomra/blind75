public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums == null || nums.Length == 1) return nums;

        int[] result = new int[nums.Length];
        
        // left pass
        int leftProduct = 1;
        for(int i = 0; i < nums.Length; i ++) {
            result[i] = leftProduct;
            leftProduct = leftProduct * nums[i];
        }

        // right pass
        int rightProduct = 1;
        for(int i = nums.Length - 1; i >= 0; i--) {
            result[i] = result[i] * rightProduct;
            rightProduct = rightProduct * nums[i];
        }

        return result;
    }
}
