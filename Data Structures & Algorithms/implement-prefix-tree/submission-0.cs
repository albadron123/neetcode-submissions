public class PrefixTree {
    TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
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
        TrieNode current = root;
        for(int i = 0; i < word.Length; ++i)
        {
            if(!current.next.ContainsKey(word[i]))
            {
                return false;
            }
            current = current.next[word[i]];
        }
        return current.isComplete;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        for(int i = 0; i < prefix.Length; ++i)
        {
            if(!current.next.ContainsKey(prefix[i]))
            {
                return false;
            }
            current = current.next[prefix[i]];
        }
        return true;
    }
}


public class TrieNode
{
    public Dictionary<char, TrieNode> next;
    public bool isComplete;

    public TrieNode(bool isComplete = false)
    {
        this.isComplete = isComplete;
        next = new();
    }
}
