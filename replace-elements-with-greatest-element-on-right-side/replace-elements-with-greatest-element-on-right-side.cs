public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int CurrentMax = -1;
        for(int i = n-1; i>=0;i--){
            int val = arr[i];
            arr[i] = CurrentMax;
            CurrentMax = Math.Max(CurrentMax , val);
        }
        return arr;
    }
}