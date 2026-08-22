public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int n = nums.Length;
        int[] ans = new int[2*n];
        int lastFilledIndex = 0;
        while(lastFilledIndex != 2*n)
        {
            for(int i=0; i<n; i++)
            {
                ans[lastFilledIndex] = nums[i];
                lastFilledIndex++;
            }
        }
        return ans;
    }
}