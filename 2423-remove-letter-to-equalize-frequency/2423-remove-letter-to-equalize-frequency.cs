public class Solution {
    public bool EqualFrequency(string word) {
        Dictionary<char,int> repeats = new  Dictionary<char,int>();
        foreach(char c in word) {
            if(!repeats.ContainsKey(c))
                repeats[c] = 0;
            repeats[c]+=1;
        }
        List<int> CharsRepeats = new List<int>();
        foreach(var pair in repeats)
            CharsRepeats.Add(pair.Value);

        for(int i=0;i<CharsRepeats.Count;i++){
            List<int> temp = new List<int>(CharsRepeats);
            if(temp[i] ==1 )temp.RemoveAt(i);
            else temp[i]--;
            if (temp.Distinct().Count() == 1)
                return true;
        }
        return false;
    }
}