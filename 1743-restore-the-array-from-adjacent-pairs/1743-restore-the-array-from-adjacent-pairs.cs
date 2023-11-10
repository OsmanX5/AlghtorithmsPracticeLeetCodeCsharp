public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        var adjList = new Dictionary<int,List<int>>();
        int head =0;
        
        //create adjList
        foreach(var pair in adjacentPairs){
            (int x ,int y ) = (pair[0] , pair[1]);
            if(!adjList.ContainsKey(x)) adjList[x] = new List<int>();
            if(!adjList.ContainsKey(y)) adjList[y] = new List<int>();
            adjList[x].Add(y);
            adjList[y].Add(x);
            
        }
        int n = adjList.Keys.ToList().Count;

        foreach(var dic in adjList) if(dic.Value.Count ==1) 
            head = dic.Key;
        int cur = adjList[head][0];

        int[] result = new int[n];
        result[0] = head;
        result[1] = cur;
        
        var visited = new HashSet<int>(){head , cur};
        for(int i=2;i<n;i++){
            var pairs = adjList[cur];
            int nextItem = pairs[0];
            if(result[i-2] == nextItem) 
                nextItem=  pairs[1] ;
            result[i] = nextItem;
            visited.Add(nextItem);
            cur = nextItem;
        }
        
        
        return result;
    }
}