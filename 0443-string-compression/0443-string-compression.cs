public class Solution {
    public int Compress(char[] chars) {
        int n =chars.Length;
        int p=0;
        int res=0;
        for(int i=0;i<n;i++){
            int count =1;
            char c = chars[i];
            while(i<n-1 && chars[i+1]==c){i++;count++;}
            chars[p++] = c;
            res++;
            if(count>1){
                char[] countChars =count.ToString().ToCharArray();
                foreach(char cc in countChars)chars[p++] = cc;
                res+=countChars.Length;
            }
            //Console.WriteLine($"{c} : {count}");
        }
        return res;
    }
}