public class Solution {
    public int MinimumDifference(int[] arr, int k) {
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach(int x in arr)Console.WriteLine(x);
        int dif =  int.MaxValue;
        for(int i=0;i<=arr.Length-k;i++)
            dif = Math.Min(dif,arr[i]-arr[i+k-1]);
        return dif;
    }
}