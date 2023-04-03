public class Solution {
    public bool EqualFrequency(string word) {
        
        var repeats = new  Dictionary<char,int>();
        foreach(char c in word) {
            if(!repeats.ContainsKey(c)) repeats[c] = 0;
            repeats[c]+=1;
        }
        var CharsRepeats = GetDictionaryValues(repeats);
        
        for(int i=0;i<CharsRepeats.Count;i++){
            int CurrentRepeat = CharsRepeats[i];
            
            List<int> temp = new List<int>(CharsRepeats);
            if(CurrentRepeat == 1)
                temp.Remove(CurrentRepeat);
            else
                temp[i]-=1;
            if (AllItemsAreEquals (temp))
                return true;
        }
        return false;
    }
    List<int> GetDictionaryValues(Dictionary<char,int> dict)
        => dict.Select(x => x.Value).ToList();
    bool AllItemsAreEquals(List<int> arr) 
        =>arr.Distinct().Count() == 1;
}