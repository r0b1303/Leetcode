public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums. Length; j++){
                if( i == j ){
                    break;
                }
                int temp = nums[i] + nums[j];
                if(temp == target){
                    return new int[]{i, j};
                }
            }
        }
        return null;
    }
}