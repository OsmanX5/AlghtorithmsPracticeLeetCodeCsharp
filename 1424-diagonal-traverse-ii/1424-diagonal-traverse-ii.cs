public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
                int row = nums.Count;
        Dictionary<int, List<int>> d = new();
        
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < nums[i].Count; j++)
            {
                int key = i + j;
                if(d.ContainsKey(key))
                    d[key].Insert(0, nums[i][j]); //Insert at beginning
                else
                {
                    d.Add(key, new() { nums[i][j] });
                }
            }
        }
        
        return d.Values.SelectMany(x => x).ToArray();
    }
}