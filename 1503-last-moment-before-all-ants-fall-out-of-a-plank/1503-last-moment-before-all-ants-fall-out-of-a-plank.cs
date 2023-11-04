public class Solution {
    public int GetLastMoment(int n, int[] left, int[] right) {
        int max =0;
        for(int i=0;i<left.Length;i++)
            if(left[i] >max) max = left[i];
        for(int i=0;i<right.Length;i++)
            if(n - right[i] >max) max =n - right[i];
        return max;
    }
}