public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n == 1) return nums[0];
        if(n == 2) return Math.Max(nums[0], nums[1]);
        if(n == 3) return Math.Max(Math.Max(nums[0], nums[1]), nums[2]);
        
        int firstMax = -1;
        int secondMax = -1;

        int left = nums[0];
        int right = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < n-1; ++i)
        {
            int temp = Math.Max(nums[i] + left, right);
            left = right; right = temp;
        }
        firstMax = right;

        left = nums[1];
        right = Math.Max(nums[1], nums[2]);
        for(int i = 3; i < n; ++i)
        {
            int temp = Math.Max(nums[i] + left, right);
            left = right; right = temp;
        }
        secondMax = right;

        return Math.Max(firstMax, secondMax);
    }
    
}
