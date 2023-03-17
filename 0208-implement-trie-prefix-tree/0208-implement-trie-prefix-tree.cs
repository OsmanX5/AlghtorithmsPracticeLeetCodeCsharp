public class TrieNode{
    Dictionary<char,TrieNode> Next = new Dictionary<char,TrieNode>();
    public bool IsWord;
    public bool Contains(char c) => Next.ContainsKey(c);
    public void Add(char c) => Next[c] = new TrieNode();
    public TrieNode GetNext(char c) => Next[c];
}
public class Trie {
    TrieNode head;
    public Trie() {
        head = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode temp =head;
        foreach(char c in word){
            if(!temp.Contains(c))
                temp.Add(c);
            temp = temp.GetNext(c);
        }
        temp.IsWord = true;
    }
    
    public bool Search(string word) {
        TrieNode temp =head;
        foreach(char c in word){
            if(!temp.Contains(c))return false;
            temp = temp.GetNext(c);
        }
        return temp.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode temp =head;
        foreach(char c in prefix){
            if(!temp.Contains(c))return false;
            temp = temp.GetNext(c);
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