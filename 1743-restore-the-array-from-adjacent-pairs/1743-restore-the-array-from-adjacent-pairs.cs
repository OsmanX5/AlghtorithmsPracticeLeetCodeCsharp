public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        var adjList = new Dictionary<int,List<int>>();
        int head =0;
        
        //create adjList
        foreach(var pair in adjacentPairs){
            int x = pair[0];
            int y = pair[1];
            if(!adjList.ContainsKey(x)) adjList[x] = new List<int>();
            if(!adjList.ContainsKey(y)) adjList[y] = new List<int>();
            adjList[x].Add(y);
            adjList[y].Add(x);
            
        }
        foreach(var dic in adjList) 
            if(dic.Value.Count ==1) head = dic.Key;
       /* foreach(var dic in adjList){
            Console.Write($"{dic.Key} : ");
            foreach(int x in dic.Value)Console.Write($" {x} ");
            Console.WriteLine("");
        }*/
        Console.WriteLine($"Head : {head}");
        var visited = new HashSet<int>();
        var nums = adjList.Keys.ToList();
        int n = nums.Count;
        int[] result = new int[n];
        result[0] = head;
        result[1] = adjList[head][0];
        int cur =  adjList[head][0];

        visited.Add(head);
        visited.Add(cur);
       for(int i=2;i<n;i++){
            var pairs = adjList[cur];
            int nextItem = pairs[0];
            if(visited.Contains(nextItem))
                nextItem=  pairs[1] ;
            result[i] = nextItem;
            visited.Add(nextItem);
            cur = nextItem;
        }
        
        
        return result;
    }
}