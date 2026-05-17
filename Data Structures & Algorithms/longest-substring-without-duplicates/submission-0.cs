public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> inSubstr = new();
        int l = 0;
        int r = 0;
        int maxlen = 0;
        int len = 0;
        while(r < s.Length)
        {
            if(inSubstr.Contains(s[r]))
            {
                while(s[l] != s[r]) 
                {
                    inSubstr.Remove(s[l]);
                    ++l;
                    --len;
                }
                ++l;
                ++r;
            }
            else
            {
                inSubstr.Add(s[r]);
                ++r;
                ++len;
                maxlen = len > maxlen? len : maxlen;
            }
        }
        return maxlen;
    }
}