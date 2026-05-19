public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool[] rows = new bool[matrix.Length];
        bool[] cols = new bool[matrix[0].Length];
        for(int i = 0; i < matrix.Length; ++i)
        {
            for(int j = 0; j < matrix[0].Length; ++j)
            {
                if(matrix[i][j] == 0)
                {
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }
        
        for(int i = 0; i < matrix.Length; ++i)
        {
            if(rows[i] == true)
            {
                for(int j = 0; j < matrix[0].Length; ++j)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        for(int j = 0; j < matrix[0].Length; ++j)
        {
            if(cols[j] == true)
            {
                for(int i = 0; i < matrix.Length; ++i)
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
