class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        if(len(nums)<2):
            return False
        visited =set([])
        for i in range( min(k+1,len(nums)) ):
            if nums[i] in visited:
                return True
            else:
                visited.add(nums[i])
        #print(visited)
        for i in range(k+1,len(nums)):
            #print(f" now i = {i}and visited  = {visited}")
            visited.remove(nums[i-k-1])
            if nums[i] in visited:
                return True
            else:
                visited.add(nums[i])
        return False
