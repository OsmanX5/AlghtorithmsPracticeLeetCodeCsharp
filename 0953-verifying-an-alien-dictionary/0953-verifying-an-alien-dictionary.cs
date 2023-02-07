public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char,int> dict = new();
        for(int i=0;i<26;i++)dict[order[i]] = i;
        dict['#'] = -1;
        bool isSorted(string x,string y){
            if ( y.Length < x.Length) 
                for(int i=0;i<=x.Length - y.Length;i++) y+='#';
            Console.WriteLine(y.Length);
            for(int i=0;i<x.Length;i++){
                char csmall = x[i];
                char clarg = y[i];
                Console.WriteLine($"csmall = {csmall} clarge = {clarg}");
                if (dict[csmall] > dict[clarg]) return false;
                if (dict[csmall]<dict[clarg]) return true;
            }
            return true;
        }
        
        int n =words.Length;
        for(int i=0;i<n-1;i++){
            if(!isSorted(words[i] , words[i+1]))
                return false;
        }
        return true;
    }

}