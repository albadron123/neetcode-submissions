public class Solution {

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new();
        for(int i = 0; i < strs.Length; ++i)
        {
            int[] chars = new int[26];
            for(int j = 0; j < strs[i].Length; ++j)
            {
                ++chars[(int)strs[i][j] - (int)'a'];
            }
            string key = string.Join(" ", chars);
            if(!result.ContainsKey(key))
            {
                result[key] = new();
            }
            result[key].Add(strs[i]);
        }

        List<List<string>> final = new();
        foreach(var res in result)
        {
            final.Add(res.Value);
        }
        return final;
    }
}
