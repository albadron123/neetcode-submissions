public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> dict = new();
        for(int i = 0; i < s.Length; ++i)
        {
            if(dict.ContainsKey(s[i]))
            {
                dict[s[i]]+=1;
            }
            else
            {
                dict[s[i]] = 1;
            }

            if(dict.ContainsKey(t[i]))
            {
                dict[t[i]]-=1;
            }
            else
            {
                dict[t[i]] = -1;
            }
        }

        foreach(var x in dict)
        {
            if(x.Value != 0) return false;
        }
        return true;
    }
}
