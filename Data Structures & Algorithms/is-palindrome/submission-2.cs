public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        for(int i = 0; i < (int)(s.Length/2); ++i)
        {
            if(s[i] != s[s.Length-i-1]) return false;
        }
        return true;
    }
}
