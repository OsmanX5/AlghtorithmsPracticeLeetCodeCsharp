public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> founded = new HashSet<int>();
        foreach(int x in nums){
            if(founded.Contains(x)) return true;
            founded.Add(x);
        }
        return false;
    }
}