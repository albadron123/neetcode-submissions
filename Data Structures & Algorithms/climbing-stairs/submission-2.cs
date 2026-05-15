public class Solution {
    public int ClimbStairs(int n) {     
        if(n <= 2) return n;
        int[] table = new int[n];
        table[n-1] = 1;
        table[n-2] = 2;
        for(int i = n-3; i >= 0; i--)
        {
            table[i] = table[i+1] + table[i+2];
        }
        return table[0];
    }
}
