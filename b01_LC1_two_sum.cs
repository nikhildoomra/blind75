public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> prevNumbers = new Dictionary<int, int>();
        prevNumbers.Add(nums[0], 0);

        for(int i = 1; i < nums.Length; i++) {
            var currentNumber = nums[i];
            var pairNumber = target - nums[i];
            if(prevNumbers.ContainsKey(pairNumber)) {
                return new int[] {
                    prevNumbers[pairNumber], i
                };
            } 

            if(!prevNumbers.ContainsKey(currentNumber)) {
                prevNumbers.Add(currentNumber, i);
            }
        }
        return new int[2];
    }
}
