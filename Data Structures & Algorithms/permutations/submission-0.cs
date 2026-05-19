public class Solution {
    List<List<int>> res;

    public List<List<int>> Permute(int[] nums) {
        res = new();
        Iteration(new List<int>(), nums.ToList());
        return res;
    }

    public void Iteration(List<int> current, List<int> nums)
    {
        if(nums.Count == 0)
        {
            res.Add(current);
            return;
        }
        for(int i = 0; i < nums.Count; ++i)
        {
            int number = nums[i];
            current.Add(nums[i]);
            List<int> nextNums = new List<int>(nums);
            nextNums.RemoveAt(i);
            Iteration(new List<int>(current), nextNums);
            current.RemoveAt(current.Count - 1);
        }
    }
}
