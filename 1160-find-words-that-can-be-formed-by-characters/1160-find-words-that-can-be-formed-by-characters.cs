public class Solution {
    public int CountCharacters(string[] words, string chars) {
        
        bool IsGood(string word){
            List<char> available = chars.ToList();
            foreach(char c in word){
                if(available.Contains(c))
                    available.Remove(c);
                else 
                    return false;
            }
            return true;
        }
        
        int res=0;
        foreach(var word in words){
            if( IsGood(word))
                res+= word.Length;
        }
        return res;
    }
}