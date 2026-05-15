public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";
        s += (char)(strs.Count);
        for(int i = 0; i < strs.Count; ++i)
        {
            s += (char)(strs[i].Length);
        }
        for(int i = 0; i < strs.Count; ++i)
        {
            s += strs[i];
        }
        return s;
    }

    public List<string> Decode(string s) {
        List<string> strs = new();
        int count = (int)s[0];
        int stringIndex = count+1;
        for(int i = 0; i < count; ++i)
        {
            string str_i = "";
            int strlen = (int)s[i+1];
            for(int j = 0; j < strlen; ++j)
            {
                str_i += s[stringIndex];
                ++stringIndex;
            }
            strs.Add(str_i);
        }
        return strs;
   }
}
