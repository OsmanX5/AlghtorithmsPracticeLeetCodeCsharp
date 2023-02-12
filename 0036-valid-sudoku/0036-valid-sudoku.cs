public class Solution {
    public bool IsValidSudoku(char[][] board) {
        return ValidateRowsAndColumns(board) && ValidateCupics(board);
    }
    
    bool ValidateRowsAndColumns(char[][] board){
        for(int i=0;i<9;i++){
            char[] row = board[i][0..9];
            char[] col = new char[10];
            for(int r=0;r<9;r++) col[r] = board[r][i];
            if(!IsValid(row)) return false;
            if(!IsValid(col)) return false;
        }
        return true;
    }
    
    bool ValidateCupics(char[][] board){
        for(int i=0;i<9;i+=3){
            for(int j=0;j<9;j+=3){
                List<char> cube= new();
                cube.AddRange(board[i][j..(j+3)]);
                cube.AddRange(board[i+1][j..(j+3)]);
                cube.AddRange(board[i+2][j..(j+3)]);
                if(!IsValid(cube.ToArray())) return false;
                
            }
        }
        return true;
    }
    
    
    bool IsValid(char[] arr){
        List<char> InArr = new();
        foreach(char c in arr){
            if (c == '.') continue;
            if(InArr.Contains(c)) return false;
            InArr.Add(c);
        }
        return true;
    }
}