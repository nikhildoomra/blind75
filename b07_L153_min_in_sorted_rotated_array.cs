public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        
        // initialze with 0th index as the array might not be rotated at all
        int result = nums[0];
        // try to find the pivot such that nums[i] > nums[i+1]
        while(l < r) {
            int m = (l + r)/2;
            
            if(nums[m] > nums[m+1]) {
                return nums[m+1];
            } else if (nums[m] > nums[r]){
                l = m + 1;
            } else {
                // middle can be the number as well so include m in the search
                r = m;
            }
        }
        return result;
    }
}
