public class Solution {
       public int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);

            int output = 0;
            int left = 0;
            int sum = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];


                while (nums[right] * (right - left + 1) - sum > k)
                {
                    sum -= nums[left];
                    left++;
                }

                output = Math.Max(output, right - left + 1);
            }

            return output;
        }
}