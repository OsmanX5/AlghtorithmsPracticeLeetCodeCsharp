public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string repated = $"{s[0]}";
        int n = s.Length;
        int p = 0;
        if(repated.Length == n )
                return false;
        for(int len =1;len<n/2+1;len++){
            if(n%len !=0 ){
                Console.WriteLine($"len = {len} , n%len = {n%len}");
                continue;
            }
            repated = s.Substring(0,len);
            Console.WriteLine($"Repated test = {repated}");
            int times = 0;
            for(int i=0;i<n;i+=len)
            {
                if(repated == s.Substring(i,len)){
                    times++;
                }
                    
                else
                    break;
            }
            Console.WriteLine($"{repated} repated for {times}");
            if(times == n/len)
                return true;
        }
        return false;
        
    }
}