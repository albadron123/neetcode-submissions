public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n == 1) return nums[0];
        if(n == 2) return Math.Max(nums[0], nums[1]);
        int left = nums[0];
        int right = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < n; ++i)
        {
            int temp = Math.Max(nums[i] + left, right);
            left = right; right = temp;
        }
        return right;
    }
}
