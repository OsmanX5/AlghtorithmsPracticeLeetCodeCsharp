public class Solution {
    public int ClosedIsland(int[][] grid) {
        if (grid == null || grid.Length == 0)
            return 0;
        
        int res = 0;
        
        int[] dx = new int[] { 0, 0, 1, -1 },
              dy = new int[] { 1, -1, 0, 0 };
        
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == 0)
                {
                    bool closed = true;
                    Queue<int[]> q = new Queue<int[]>();
                    
                    q.Enqueue(new int[] { i, j });
                    grid[i][j] = -1;
                    
                    while (q.Count > 0)
                    {
                        int[] cur = q.Dequeue();
                        
                        for (int k = 0; k < 4; k++)
                        {
                            int newX = cur[0] + dx[k],
                                newY = cur[1] + dy[k];
                            
                            if (newX == -1 || newX == grid.Length || newY == -1 || newY == grid[0].Length)
                                closed = false;
                            else if (grid[newX][newY] == 0)
                            {
                                q.Enqueue(new int[] { newX, newY });
                                grid[newX][newY] = -1;
                            }
                        }
                    }
                    
                    if (closed)
                        res++;
                }
        
        return res;
    }
}