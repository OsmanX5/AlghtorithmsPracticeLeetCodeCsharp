class Solution:
    def findMin(self, nums: List[int]) -> int:
        s = set(nums)
        return min(s)
        