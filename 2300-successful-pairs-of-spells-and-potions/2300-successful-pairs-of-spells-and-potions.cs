public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int n = spells.Length;
        int[] res = new int[n];
        Array.Sort(potions);
        for(int i=0;i<n;i++){
            res[i] = Count(spells[i],potions ,success);
        }
        return res;
    }
    public int Count(long x ,int[] arr,long success){
        int n = arr.Length;
        int l=0;
        int r = arr.Length-1;
        int mid;
        long p;
        while(l<r){
            mid = l + (r-l)/2;
            p = x * (long) arr[mid];
            if(p<success)
                l = mid+1;
            else
                r = mid;
        }
        p = x * (long) arr[l];
        if(l ==0 && p>=success)
            return n;
        if (l == n && p<success)
            return 0;
        if(p>=success)
            return n-l;
        return n-l-1;
    }
}