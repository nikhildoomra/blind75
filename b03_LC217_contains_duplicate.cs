public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach(var num in nums) {
            var added = set.Add(num);
            if (!added) return true;
        }
        return false;
    }
}
