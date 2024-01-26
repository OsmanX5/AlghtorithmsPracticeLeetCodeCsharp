public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string repated = "";
        int n = s.Length;
        for(int len =1;len<n/2+1;len++){
            if(n%len !=0 )
                continue;
            repated = s.Substring(0,len);
            int times = 0;
            for(int i=0;i<n;i+=len)
            {
                if(repated == s.Substring(i,len))
                    times++;
                else
                    break;
            }
            if(times == n/len)
                return true;
        }
        return false;
        
    }
}