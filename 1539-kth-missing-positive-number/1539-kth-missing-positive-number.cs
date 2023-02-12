public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        HashSet<int> all = new();
        for(int i=1;i<arr.Max() +k+1;i++)all.Add(i);
        foreach(int x in all)Console.Write($" {x} ");
        Console.WriteLine();
        for(int i=0;i<arr.Length;i++)all.Remove(arr[i]);
        int[] deleted= all.ToArray();
        foreach(int x in deleted)Console.Write($" {x} ");
        return deleted[k-1];
    }
}