public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0;
        int realsum = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            realsum += nums[i];
            sum += i;
        }
        sum += nums.Length;
        return sum - realsum;
    }
}
