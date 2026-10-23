public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                return [i, dict[target - nums[i]]];
            }
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
        }
        return [0];
    }
}
