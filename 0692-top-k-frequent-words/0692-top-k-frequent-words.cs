public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string,int> repate = new Dictionary<string,int>();
        foreach(string word in words){
            if(!repate.ContainsKey(word))repate[word] =0;
            repate[word]+=1;
        }
        
        var sortedDict = repate.OrderByDescending(x =>x.Value).ToList();
        
       // foreach(var pair in sortedDict) Console.WriteLine($"{pair.Key} : {pair.Value}");
        var group = sortedDict.GroupBy(x => x.Value);
        List<string> res= new();
        foreach( var g in group){
            List<String> s = new List<String> ();
            foreach(var gg in g){
                s.Add(gg.Key);
            }
            s.Sort();
            res.AddRange(s);
        }
        return res.GetRange(0,k);
    }
}