public class Solution {
    public int MaximumSum(int[] nums) {
        	int DigitSum(int x) => x.ToString().Select(c => (int)(c-'0')).Sum();
			var group = nums.GroupBy(x => DigitSum(x));
			int bestMax = -1;
			foreach (var g in group)
			{
				var list = g.ToList();
				list.Sort();
				if (list.Count > 1) bestMax = Math.Max(bestMax, list[list.Count - 1] + list[list.Count - 2]);
			}
        return bestMax;
    }
}