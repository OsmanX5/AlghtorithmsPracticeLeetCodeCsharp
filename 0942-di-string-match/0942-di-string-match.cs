public class Solution {
    public int[] DiStringMatch(string s) {
        int n =s.Length;
        int l=0;
        int r=s.Length;
        int[] res = new int[n+1];
        List<int> Ds =new List<int>();
        List<int> Is = new List<int>();
        for(int i=0;i<n;i++){
            if(s[i] == 'I')Is.Add(i);
            else Ds.Add(i);
        }
        for(int i = Is.Count-1;i>=0;i--){
            int index = Is[i]+1;
            res[index] = r;
            r--;
        }
        for(int i = Ds.Count-1;i>=0;i--){
            int index = Ds[i]+1;
            res[index] = l;
            l++;
        }
        res[0] = l;
        return res;
    }
}