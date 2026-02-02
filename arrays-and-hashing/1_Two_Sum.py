class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        n = len(nums)
        for i in range(0, n):
            for j in range(0, n):
                if i == j:
                    break
                else:
                    calc = nums[i] + nums[j]
                    if calc == target:
                        return i,j