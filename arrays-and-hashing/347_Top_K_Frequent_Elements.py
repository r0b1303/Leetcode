class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dic = {}
        for num in nums:
            if(num not in dic):
                dic[num] = 0
            dic[num] += 1
        
        maxi = 0
        for key in dic:
            if(dic[key] > maxi)
                maxi = dic[key]