public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefixes = new int[nums.Length];
        int[] suffixes = new int[nums.Length];
        int tempProduct = 1;
        prefixes[0] = 1;
        for(int i = 0; i < nums.Length-1; ++i)
        {
            tempProduct *= nums[i];
            prefixes[i+1] = tempProduct;
        }
        
        tempProduct = 1;
        suffixes[nums.Length-1] = 1;
        for(int i = nums.Length-1; i >= 1; --i)
        {
            tempProduct *= nums[i];
            suffixes[i-1] = tempProduct;
        }

        for(int i = 0; i < nums.Length; ++i)
        {
            nums[i] = prefixes[i] * suffixes[i];
        }

        return nums;

    }
    public int[] ProductExceptSelf1(int[] nums) {
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
