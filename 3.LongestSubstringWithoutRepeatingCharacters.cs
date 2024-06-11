namespace MyApp;

public class Solution3 {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> letter = new();
        int left = 0, right = 0, length = s.Length, count = 0, max = 0;
        while (right < length) {
            if (!letter.Contains(s[right])) {
                letter.Add(s[right++]);
                count++;
            } else {
                letter.Remove(s[left++]);
                count--;
            }
            max = Math.Max(max, count);
        }
        return max;       
    }
}