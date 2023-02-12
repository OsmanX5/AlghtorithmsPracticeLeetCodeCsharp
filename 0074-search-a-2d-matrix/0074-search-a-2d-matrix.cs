public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n =matrix.Length;
        int m = matrix[0].Length;
        for(int i=0;i<n;i++){
            if(matrix[i][m-1] < target)continue;
            for(int j=0;j<m;j++)
                if( matrix[i][j] == target)return true;
        }
        return false;
    }
}