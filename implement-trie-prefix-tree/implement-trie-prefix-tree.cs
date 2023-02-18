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
    
    public bool Search(string word) {
        TrieNode temp = root;
        foreach(char c in word){
            if (!temp.Contains(c)) return false;
             temp = temp.children[c];
        }
        return temp.isWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode temp = root;
        foreach(char c in prefix){
            if (!temp.Contains(c)) return false;
             temp = temp.children[c];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */