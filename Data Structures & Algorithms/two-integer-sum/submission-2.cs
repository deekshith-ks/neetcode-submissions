public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> seen = new Dictionary<int, int>();
var result = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            var difference = target - nums[i];
            if(seen.ContainsKey(difference)){
                result.Add(seen[difference]);
                result.Add(i);
                return result.ToArray();
            }
            else {
                seen.Add(nums[i], i);
            }
        }
    return null;
}

}


