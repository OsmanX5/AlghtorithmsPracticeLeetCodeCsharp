public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int n =mat.Length;
        Dictionary<int,int> Powers = new();
        for(int i=0;i<n;i++){
            int rowPower = mat[i].Count(x => x==1);
            Powers[i] = rowPower;
        }
        Powers = Powers.OrderBy(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);

        List<int> keys =new();
        foreach(int x in Powers.Keys)keys.Add(x);
        return keys.ToArray()[0..k];
    }
}