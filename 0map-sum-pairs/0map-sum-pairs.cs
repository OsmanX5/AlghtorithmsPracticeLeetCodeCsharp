public class MapSum {
    Dictionary<string,int> scores;
    Trie trie;
    public MapSum() {
        scores = new Dictionary<string,int>();
        trie = new Trie();
    }
    
    public void Insert(string key, int val) {
        Console.WriteLine($"\n\nDictionary before insertion {key} {val}");
        foreach(var pair in scores)Console.WriteLine($"{pair.Key} : {pair.Value}");
        if(scores.ContainsKey(key)){
            int old = scores[key];
            scores[key] = val;
            val  = val -old;
        }
        else{
           scores[key] = val; 
        }
        trie.Insert(key,val);
    }
    
    public int Sum(string prefix) {
        return trie.getScore(prefix);
    }
}
public class TrieNode{
    public Dictionary<char , TrieNode> children;
    public int val;
    public TrieNode(){
        children=  new Dictionary<char , TrieNode>();
        val = 0;
    }
    public bool Contains(char c){
        return children.ContainsKey(c);
    }
    public void AddChield(char c){
        children[c] = new TrieNode();
    }
}
public class Trie {
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word,int score) {
        TrieNode temp = root;
        Console.WriteLine($"Insert {word} with score {score}");
        foreach(char c in word){
            if (!temp.Contains(c)){
                temp.AddChield(c);
            }
            temp = temp.children[c];
            temp.val += score; 
            Console.WriteLine($" chield of {c} = {temp.val} ");
        }
    }
    
    public int getScore(string prefix) {
        Console.WriteLine($"Get score of {prefix}");
        TrieNode temp = root;
        foreach(char c in prefix){
            if (!temp.Contains(c)) return 0;
            Console.WriteLine($"now c ={c} score = {temp.val}");
            temp = temp.children[c];
        }
        Console.WriteLine($"score = {temp.val}");
        return temp.val;
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */