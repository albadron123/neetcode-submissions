public class Solution {
    public int Search(int[] nums, int target) {
        int ceil = nums.Length;
        int floor = -1;
        int searchIndex;
        do
        { 
            searchIndex = (int) ((ceil + floor) / 2);
            int peek = nums[searchIndex];
            if(peek == target)
            {
                return searchIndex;
            }
            if(peek < target)
            {
                floor = searchIndex;
            }
            else
            {
                ceil = searchIndex;
            }
        } while(ceil - floor != 1);
        return -1;
    }
}
