public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        Trie trie = new Trie();
        trie.InsertRange(wordDict);
        
        return trie.CanBeFormed(trie.root,s,0);
    }
}
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isWord = false;
        public bool Contains(char c) => children.ContainsKey(c);
        public bool isLeaf() => children.Count == 0;
        public void AddChield(char c) => children[c] = new TrieNode();
        public TrieNode getNext(char c) => children[c];
        public List<TrieNode> childrensNodes() => (from x in children select x.Value).ToList();
        public void printDict()
        {
            Console.WriteLine("childs");
            foreach (var pair in children)
            {
                Console.Write($"{pair.Key} : ");
                foreach (char c in pair.Value.children.Keys) Console.Write($" {c} ");
                Console.WriteLine();
            }
        }
    }
    public class Trie
    {
        
        public TrieNode root;
        public Trie() {
            root = new TrieNode();
            dp =new Dictionary<Tuple<TrieNode,int>,bool>();
        } 

        public void InsertRange(IEnumerable range)
        {
            foreach (string word in range)
                this.Insert(word);
        }
        public void Insert(string word)
        {
            TrieNode temp = root;
            foreach (char c in word)
            {
                if (!temp.Contains(c)) temp.AddChield(c);
                temp = temp.getNext(c);
            }
            temp.isWord = true;
        }
        Dictionary<Tuple<TrieNode,int>,bool> dp;
        
        public bool CanBeFormed(TrieNode node,string s,int index)
        {
            Tuple<TrieNode,int> tp = new Tuple<TrieNode,int>(node,index);
            if(dp.ContainsKey(tp)) 
                return dp[tp];
            if (index == s.Length)
            {
                dp[tp] = node.isWord;
                return dp[tp];
            }
            char c = s[index];
            if(node.isLeaf()) return CanBeFormed(root,s, index );
            if (!node.Contains(c)){
                dp[tp] = false;
                return dp[tp];  
            } 
            TrieNode next = node.getNext(c);
            if (next.isWord){
                dp[tp] = CanBeFormed(root,s, index + 1) || CanBeFormed(next,s,index+1);
                return dp[tp];
            }
            dp[tp] = CanBeFormed(next, s, index + 1);
            return dp[tp];
        }
    }