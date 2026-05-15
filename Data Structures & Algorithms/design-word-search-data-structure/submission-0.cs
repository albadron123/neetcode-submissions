public class WordDictionary {
    TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode current = root;
        for(int i = 0; i < word.Length; ++i)
        {
            if(!current.next.ContainsKey(word[i]))
            {
                current.next[word[i]] = new TrieNode();
            }
            current = current.next[word[i]];
        }
        current.isComplete = true;
    }
    
    public bool Search(string word) {
        return SearchTrie(root, word, 0);
    }

    private static bool SearchTrie(TrieNode initial, string word, int index)
    {
        TrieNode current = initial;
        for(int i = index; i < word.Length; ++i)
        {
            if(word[i] == '.')
            {
                if(i == word.Length-1)
                {
                    foreach(var x in current.next)
                    {
                        if(x.Value.isComplete) return true;
                    }
                    return false;
                }
                else
                {
                    foreach(var x in current.next)
                    {
                        if(SearchTrie(x.Value, word, i+1))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            if(!current.next.ContainsKey(word[i]))
            {
                return false;
            }
            current = current.next[word[i]];
        }
        return current.isComplete;
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> next;
    public bool isComplete;
    public TrieNode()
    {
        isComplete = false;
        next = new();
    }
}
