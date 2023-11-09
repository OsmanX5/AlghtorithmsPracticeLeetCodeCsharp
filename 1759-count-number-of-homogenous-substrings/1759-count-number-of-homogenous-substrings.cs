public class Solution {
    public int CountHomogenous(string s) {
        int n = s.Length;
        List<int> lens = new List<int>();
        char last ='_';
        int subLen =0;
        for(int i=0;i<n;i++){
            
            if(s[i] != last ){
                lens.Add(subLen);
                subLen =0;
            }
            subLen+=1;
            last = s[i];
        }
        lens.Add(subLen);
        long res =0;
        for(int i=0;i<lens.Count;i++){
            double x = (double)lens[i];
            double mid = (double)((x+1)/2.0);
            long sum = (long)(x*mid);
            //Console.WriteLine($"sub len = {x} , and add = {sum}");
            res+= sum ;
            
        }

        return (int)(res% 1000000007);
    }
}