public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        Array.Sort(arr2);
        int res = arr1.Length;
        foreach(int x in arr1){
            foreach(int y in arr2){
                if (Math.Abs(x-y)<=d){
                    res--;
                    break;
                }
            }
        }
        return res;
    }
}