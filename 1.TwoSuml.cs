namespace MyApp;
public class Solution1 {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            if (dic.ContainsKey(temp))
            {
                return new int[2] {dic[temp], i};
            }
            dic.TryAdd(nums[i], i);
        }
        return null;
    }
}