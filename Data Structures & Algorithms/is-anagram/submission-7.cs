public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] dict = new int[26];
        for(int i = 0; i < s.Length; ++i)
        {
            dict[(int)s[i]-(int)'a']+=1;
            dict[(int)t[i]-(int)'a']-=1;
        }

        foreach(var x in dict)
        {
            if(x != 0) return false;
        }
        return true;
    }
}
