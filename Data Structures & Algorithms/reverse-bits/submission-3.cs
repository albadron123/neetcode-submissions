public class Solution {
    public uint ReverseBits(uint n) {
        uint result = 0;
        for(int i = 0; i < 16; ++i)
        {
            uint bit = (n >> i) & 1;
            uint otherbit = (n >> (31-i)) & 1;
            
            result = (uint)(result | (bit << (31-i)) | (otherbit << i));
        }   
        return result;
    }
}
