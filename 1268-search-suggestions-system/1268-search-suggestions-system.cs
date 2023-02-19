public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Trie trie = new Trie();
        foreach(string product in products)trie.Insert(product);
        IList<IList<string>> res = new  List<IList<string>>();
        string prefix ="";
        for(int i=0;i<searchWord.Length;i++){
            prefix += searchWord[i];
            List<string> words = trie.nextWords(prefix);
            words.Sort();
            if(words.Count>3)
                res.Add(words.GetRange(0,3));
            else
                res.Add(words);
        }
        
        
        return res;
    }
}
public class TrieNode{
    public Dictionary<char , TrieNode> children;
    public bool isWord;
    public TrieNode(){
        children=  new Dictionary<char , TrieNode>();
        isWord = false;
    }
    public bool Contains(char c){
        return children.ContainsKey(c);
    }
    public void AddChield(char c){
        children[c] = new TrieNode();
    }
    public TrieNode getNext(char c) => children[c];
    public List<TrieNode> childrensNodes(){
        return (from x in children select x.Value).ToList();
    }
}
public class Trie {
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode temp = root;
        foreach(char c in word){
            if (!temp.Contains(c)){
                temp.AddChield(c);
            }
            temp = temp.children[c];
        }
        temp.isWord = true;
    }
    
    public List<string> nextWords(string prefix){
        List<string> res = new List<string>();
        TrieNode temp = root;
        foreach(char c in prefix){
            if(!temp.Contains(c)) return res;
            temp = temp.getNext(c);
        }
        return allNextWord(temp,prefix);
    }
    List<string> allNextWord(TrieNode startNode,string startPrefix){
        List<String> res = new List<string>();
        
        void DFS(TrieNode node, string word){
            if(node.isWord ) res.Add(word);
            foreach(var nextPair in node.children){
                DFS(nextPair.Value,word+nextPair.Key);
            }
        }
        DFS(startNode,startPrefix);
        
        return res;
    }
}
