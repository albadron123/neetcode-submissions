public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        if(n <= 2) return cost[0];
        int[] table = new int[n];
        table[n-1] = cost[n-1];
        table[n-2] = cost[n-2];
        for(int i = n-3; i >= 0; i--)
        {
            table[i] = cost[i] + Math.Min(table[i+1], table[i+2]);
        }
        return Math.Min(table[0],table[1]);
    }
}
