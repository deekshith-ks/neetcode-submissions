public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int current = 0;
        int max_count = 0;

        foreach(int num in nums)
        {
            if(num == 1)
            {
                current += 1;
                max_count = Math.Max(current, max_count);
            }
            else
            {
                current = 0;
            }
        }
        return max_count;
    }
}