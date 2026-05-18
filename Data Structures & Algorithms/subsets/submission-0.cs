public class Solution {

    private List<List<int>> res; 
    
    public List<List<int>> Subsets(int[] nums) {
        res = new();
        List<int> current = new();
        Recursive(current, nums, 0);
        return res;
    }

    public void Recursive(List<int> current, int[] nums, int index)
    {
        if(index == nums.Length) 
        {
            res.Add(new List<int>(current));
            return;
        }
        current.Add(nums[index]);
        Recursive(current, nums, index+1);
        current.RemoveAt(current.Count-1);
        Recursive(current, nums, index+1);
    }
}
