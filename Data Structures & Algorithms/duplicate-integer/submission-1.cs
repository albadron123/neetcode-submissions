public class Solution {
    public bool hasDuplicate(int[] nums) {
        int[] contained = new int[nums.Length];
        int containedSize = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            for(int j = 0; j < containedSize; j++)
            {
                if(contained[j] == nums[i])
                {
                    return true;
                }
            }
            contained[containedSize] = nums[i];
            ++containedSize;
        }
        return false;
    }
}