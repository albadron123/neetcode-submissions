public class Solution {
    List<List<int>> res;

    public List<List<int>> Permute(int[] nums) {
        res = new();
        Iteration(new List<int>(), nums.ToList(), 0);
        return res;
    }

    public void Iteration(List<int> current, List<int> nums, int mask)
    {
        if(current.Count == nums.Count)
        {
            res.Add(current);
            return;
        }
        for(int i = 0; i < nums.Count; ++i)
        {
            if((mask & (1 << i)) == 0)
            {
                current.Add(nums[i]);
                Iteration(new List<int>(current), nums, mask | (1 << i));
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
