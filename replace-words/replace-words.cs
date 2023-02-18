public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        Trie trie = new Trie();
        foreach( string s in dictionary) trie.Insert(s);
        string[] words = sentence.Split(" ");
        string res ="";
        for(int i=0;i<words.Length;i++){
            string word = words[i];
            res+=trie.getRoot(word);
            if(i != words.Length-1 ) res+= " ";
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
    
    public string getRoot(string word){
        TrieNode temp = root;
        string s ="";
        foreach(char c in word){
            if(temp.isWord) return s;
            if (!temp.Contains(c)) return word;
            s+=c;
            temp = temp.children[c];
        }
        return s;
    }



}