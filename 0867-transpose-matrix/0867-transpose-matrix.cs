public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int[][] res = new int[m][];
        for(int i=0;i<m;i++)
            res[i] = new int[n];
        printArray(matrix);
        printArray(res);
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                res[j][i] = matrix[i][j];
        return res;
        
    }
    void printArray(int[][] arr){
        int n = arr.Length;
        int m = arr[0].Length;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++)
            {
                Console.Write($"  {arr[i][j]}  ");
            }
            Console.WriteLine("");
        }
            
 
    }
}