public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int x in nums){
            if(!dict.ContainsKey(x))dict[x]=0;
            dict[x]++;
        }
        foreach(var pair in dict){
            if(pair.Value==1)return pair.Key;
        }
        return 0;
    }
}