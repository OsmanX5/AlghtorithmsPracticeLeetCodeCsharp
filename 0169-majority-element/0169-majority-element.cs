public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        foreach(int x in nums){
            if(!count.ContainsKey(x))count[x]=0;
            count[x]++;
            if(count[x] > nums.Length/2)return x; 
        }
        return 0;
    }
}