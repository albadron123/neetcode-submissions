public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> parans = new();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '[' || s[i] == '(' || s[i] == '{')
            {
                parans.Push(s[i]);
            }
            else
            {
                if (parans.Count == 0) return false;

                char val = parans.Pop();
                if (val == '[' && s[i] != ']' ||
                    val == '(' && s[i] != ')' ||
                    val == '{' && s[i] != '}')
                {
                    return false;
                }
            }
        }
        if (parans.Count != 0) return false;
        return true;
    }
}
