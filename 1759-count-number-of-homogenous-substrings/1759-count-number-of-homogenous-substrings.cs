public class Solution {
    public int CountHomogenous(string s) {
        int n = s.Length;
        char last ='_';
        int subLen =0;
        long res =0;
        for(int i=0;i<n;i++){
            if(s[i] != last ){
                res+= (long)(subLen*((subLen+1)/2.0));
                subLen =0;
            }
            subLen+=1;
            last = s[i];
        }
        res+= (long)(subLen*((subLen+1)/2.0));
        return (int)(res% 1000000007);
    }
}