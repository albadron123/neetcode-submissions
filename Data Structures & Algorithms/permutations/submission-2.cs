public class Solution {
    List<List<int>> res;

    public List<List<int>> Permute(int[] nums) {
        res = new();
        Iteration(new List<int>(), nums, 0);
        return res;
    }

    public void Iteration(List<int> current, int[] nums, int mask)
    {
        if(current.Count == nums.Length)
        {
            res.Add(new List<int>(current));
            return;
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            if((mask & (1 << i)) == 0)
            {
                current.Add(nums[i]);
                Iteration(current, nums, mask | (1 << i));
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
