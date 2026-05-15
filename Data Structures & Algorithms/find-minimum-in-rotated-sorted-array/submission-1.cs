public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length-1;
        int mid = left + (right-left)/2;
        do
        {
        if(nums[left] < nums[mid])
        {
            left = mid;
        }
        else 
        {
            right = mid;
        }
        mid = left + (right-left)/2;
        } while(right - left > 1);
        return Math.Min(Math.Min(nums[left], nums[right]), nums[(right+1)%nums.Length]);
    }
}
