public class Solution {
    public int HammingWeight(uint n) {
        uint counter = 0;
        for(int i = 0; i < 32; ++i)
        {
            counter += (n >> i) & 1;
        }
        return (int)counter;
    }
}
