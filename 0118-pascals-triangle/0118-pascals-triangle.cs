public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascal = new List<IList<int>>();
        pascal.Add(new List<int>(){1});
        
        for(int i=1;i<numRows;i++){
            IList<int> row = new List<int>();
            row.Add(1);
            IList<int> prevRow = pascal[i-1];
            for(int j=0;j<prevRow.Count-1;j++){
                row.Add(prevRow[j] + prevRow[j+1]);
            }
            row.Add(1);
            pascal.Add(row);
        }
        return pascal;
        
    }
}