public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> dict = new();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                return true;
            }
            dict.Add(nums[i], i);
        }
        return false;
    }
}
