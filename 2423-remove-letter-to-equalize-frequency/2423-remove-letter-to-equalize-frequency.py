class Solution:
    def equalFrequency(self, word: str) -> bool:
        repeats ={}
        for c in word:
            if c not in repeats:
                repeats[c] = 0
            repeats[c] +=1
        repeatsCount =list(repeats.values());
        for i in range(len(repeatsCount)):
            currentRepate =repeatsCount[i]
            temp = list(repeatsCount)
            if (currentRepate ==1):
                temp.remove(currentRepate)
            else:
                temp[i]-=1
            if(len(set(temp)) ==1 ):
                return True
        return False
            