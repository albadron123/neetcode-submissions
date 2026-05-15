public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n == 1) return nums[0];
        if(n == 2) return Math.Max(nums[0], nums[1]);
        int[] rewards = new int[n];
        rewards[0] = nums[0];
        rewards[1] = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < n; ++i)
        {
            rewards[i] = Math.Max(nums[i] + rewards[i-2], rewards[i-1]);
        }
        return rewards[n-1];
    }
}
