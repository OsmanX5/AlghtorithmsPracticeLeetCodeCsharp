public class Solution {
    public int MinJumps(int[] arr) {
       
        int n = arr.Length;
        Dictionary<int, List<int>> NumbersPositions = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            if (!NumbersPositions.ContainsKey(arr[i]))
                NumbersPositions.Add(arr[i], new List<int>());
            NumbersPositions[arr[i]].Add(i);
        }
        int Jumps = -1;


        bool[] Visited = new bool[n];
        Queue<int> BFS = new Queue<int>();
        BFS.Enqueue(0);
        int level = 0;
        int nextLevel = 1;
        //Console.Write(" this Level : ");
        while (BFS.Count > 0)
        {
            if (level == 0)
            {
                //Console.WriteLine("\n this  a jump : ");
                Jumps++;
                level = nextLevel;
                nextLevel = 0;
            }
            int a = BFS.Dequeue();
            level--;
            
            if (Visited[a]) continue;
            Visited[a] = true;
           // Console.WriteLine($"now visiting {a} ");
            if (a == n - 1)
            {
                //Console.WriteLine("break");
                break;
            }
            //Console.Write("Adding [ ");
            if (a - 1 > 0) {
               // Console.Write($" {a - 1}");
                BFS.Enqueue(a - 1); 
                nextLevel++; 
            }
            if (a + 1 < n) { //Console.Write($" {a +1} "); 
                BFS.Enqueue(a + 1); 
                nextLevel++; 
            }
            if (NumbersPositions.ContainsKey(arr[a]))
            {
                foreach (int x in NumbersPositions[arr[a]])
                {
                    if (x != a)
                    {
                        //Console.Write($" {x} ");
                        BFS.Enqueue(x);
                        nextLevel++;
                    }
                }
            }
            //Console.WriteLine("]");
            NumbersPositions.Remove(arr[a]);

        }
        return Jumps;
		
    }
}