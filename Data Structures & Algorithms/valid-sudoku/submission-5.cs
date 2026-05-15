public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rowsContainer = new HashSet<char>[9];
        HashSet<char>[] colsContainer = new HashSet<char>[9];
        HashSet<char>[] squaresContainer = new HashSet<char>[9];
        for(int i = 0; i < 9; ++i)
        {
            rowsContainer[i] = new();
            colsContainer[i] = new();
            squaresContainer[i] = new();
        }
        
        for(int y = 0; y < 9; ++y)
        {
            for(int x = 0; x < 9; ++x)
            {
                if(board[y][x] == '.') continue;
                char value = board[y][x];
                int square = 3 * (int)(y / 3) + (int)(x / 3);
                if(rowsContainer[y].Contains(value) ||
                   colsContainer[x].Contains(value) ||
                   squaresContainer[square].Contains(value))
                {
                    return false;
                }
                rowsContainer[y].Add(value);
                colsContainer[x].Add(value);
                squaresContainer[square].Add(value);
            }
        }
        return true;
    }
}
