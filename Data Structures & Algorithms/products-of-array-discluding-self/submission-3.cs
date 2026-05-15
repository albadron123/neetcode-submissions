public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1;
        int zeroCount = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] == 0) 
            {
                ++zeroCount;
            }
            else
            {
                totalProduct *= nums[i];
            }
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] == 0) 
            {
                if(zeroCount > 1) nums[i] = 0;
                else nums[i] = totalProduct;
            }
            else
            {
                if(zeroCount > 0) nums[i] = 0;
                else nums[i] = totalProduct / nums[i];
            }
        }
        return nums;
    }
}
