public class Solution {
    public int MinOperations(string s) {
        
        int n = s.Length;
        string idle1 = create(n,'0');
        string idle2 = create(n,'1');
        int dif1 =0;
        int dif2 =0;
        for(int i=0;i<n;i++){
            if(s[i]!= idle1[i])
                dif1++;
            if(s[i]!=idle2[i])
                dif2++;
        }
        return Math.Min(dif1,dif2);
    }
    string create(int n,char c){
        string s ="";
        for(int i=0;i<n;i++){
            s += c;
            c = flip(c);
        }
        return s;
    }
    char flip(char c) =>  c=='1'? '0' :'1';
}