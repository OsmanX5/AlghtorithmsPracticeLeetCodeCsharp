public class WordDictionary {
    Trie trie;
    public WordDictionary() {
        trie = new Trie();
    }
    
    public void AddWord(string word) {
        trie.Insert(word);
    }
    
    public bool Search(string word) {
        return trie.Search(word);
    }
}
public class TrieNode{
    public Dictionary<char , TrieNode> children;
    public bool isWord;
    public TrieNode(){
        children=  new Dictionary<char , TrieNode>();
        isWord = false;
    }
    public bool Contains(char c)=> children.ContainsKey(c);
    public void AddChield(char c)=> children[c] = new TrieNode();
    public void printDict(){
         foreach(var pair in  children){
             Console.Write($"{pair.Key} : ");
             foreach(char c in pair.Value.children.Keys)
                 Console.Write($" {c} ");
             Console.WriteLine("");
         }                     
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
            if (!temp.Contains(c)) temp.AddChield(c);
            temp = temp.children[c];
        }
        temp.isWord = true;
    }
   
    public bool Search(string word) {
        Console.WriteLine($"Search for {word}");
        bool result = false;
        void DFS(TrieNode node,int index){
            if(index == word.Length && node.isWord) result =true;
            if(index>= word.Length) return;
            char nextChar = word[index];
            if (nextChar =='.')
                foreach(var pair in node.children)
                    DFS(pair.Value,index+1);
            else{
                if(node.Contains(nextChar))
                    DFS(node.children[nextChar],index+1);
            }
                
        }
        DFS(root,0);
        return result;
    }
    public void printTrie(){
        Console.WriteLine("Printing the Trie");
        void DFS(TrieNode node){
            node.printDict();
            foreach( var next in node.children)
                DFS(next.Value);
        }
        DFS(root);
        Console.WriteLine("### finish ###");
    }
    
    
}
/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */