public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
int n = days.Length;
		int[] dp = new int[n];
		for (int i = 0; i < n; i++) dp[i] = -1;
		int helper(int dayIndex)
		{
			if (dp[dayIndex] != -1)
				return dp[dayIndex];

			int cost1 = costs[0];
			if (dayIndex < n-1)
				cost1 += helper(dayIndex + 1);

			int indexOfFirstDayInNextWeek = NextDayOutOfThisWeek(dayIndex);
			int cost2 = costs[1];
			if (indexOfFirstDayInNextWeek != -1)
				cost2 += helper(indexOfFirstDayInNextWeek);

			int indexOfFirstDayInNextMonth = NextDayOutOfThisMonth(dayIndex);
			int cost3 = costs[2];
			if (indexOfFirstDayInNextMonth != -1)
				cost3 += helper(indexOfFirstDayInNextMonth);

			dp[dayIndex] = Math.Min(cost1, Math.Min(cost2, cost3));
			return dp[dayIndex];
		}
		int NextDayOutOfThisWeek(int currentIndex)
		{
			for (int i = currentIndex; i < n; i++)
				if (days[i] - days[currentIndex] >= 7)
					return i;
			return -1;
		}
		int NextDayOutOfThisMonth(int currentIndex)
		{
			for (int i = currentIndex; i < days.Length; i++)
				if (days[i] - days[currentIndex] >= 30)
					return i;
			return -1;
		}
		int res = helper(0);
		return res;
    }
    
}