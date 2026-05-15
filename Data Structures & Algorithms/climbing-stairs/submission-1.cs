public class Solution {
    public int ClimbStairs(int n) {     
        int[] table = new int[n];
        table[n-1] = 1;
        for(int i = n-2; i >= 0; i--)
        {
            int first = table[i+1];
            int second = i+2 >= n? 1 : table[i+2];
            table[i] = first + second;
        }
        return table[0];
    }
}
