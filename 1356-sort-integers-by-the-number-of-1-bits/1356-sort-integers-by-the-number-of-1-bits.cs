public class Solution {
    public int[] SortByBits(int[] arr) {
        return arr.Select(x=>x).
                OrderBy(OnesCount).
                ThenBy(x=>x).
                ToArray();
    }
    public int  OnesCount(int x)=>(Convert.ToString(x,2).
                                   Select(x=>x).
                                   Where(x=>x == '1')).
                                    Count();
}