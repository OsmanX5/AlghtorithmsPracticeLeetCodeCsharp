/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> res = new List<IList<int>>();
        if(root ==null) return res;
        Queue<Node> BFS =new Queue<Node>();
        BFS.Enqueue(root);
        int NextLevelCount =1;
        while(BFS.Count>0){
            IList<int> thisLevel = new List<int>();
            int thisLevelCount = NextLevelCount;
            NextLevelCount=0;
            Console.WriteLine($"start loop this = {thisLevelCount} ");
            for(int i=0;i<thisLevelCount;i++){
                Node now = BFS.Dequeue();
                thisLevel.Add(now.val);
                NextLevelCount += now.children.Count();
                foreach(Node next in now.children){
                    BFS.Enqueue(next);
                }
                Console.WriteLine($"{now.val} nextCount ={NextLevelCount} ,");
            }
            res.Add(thisLevel);
        }
        return res;
    }
}