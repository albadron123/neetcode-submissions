public class Solution {
    public int[] CountBits(int n) {
        int[] counters = new int[n+1];
        counters[0] = 0;
        for(int i = 1; i <= n; ++i)
        {
            int counter = 0;
            for(int j = 0; j < 32; ++j)
            {
                counter += (i >> j) & 1;
            }
            counters[i] = counter;
        }
        return counters;
    }
}
