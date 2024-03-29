public class Solution
    {
        private const int MODULO = 1_000_000_007;

        public int NumberOfArrays(string s, int k)
        {
            checked
            {
                ulong[] dp = new ulong[s.Length];
                ulong ulK = (ulong) k;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    ulong currNum = (ulong) (s[i] - '0');

                    if (i == s.Length - 1)
                    {
                        if (currNum <= ulK && currNum >= 1)
                        {
                            dp[i] = 1;
                        }
                        continue;
                    }

                    if (currNum == 0)
                    {
                        //trailing zero
                        continue;
                    }

                    int j = i + 1;
                    while (j < s.Length && currNum <= ulK && currNum >= 1)
                    {
                        dp[i] += dp[j];
                        dp[i] %= MODULO;

                        currNum *= 10;
                        currNum += (ulong) (s[j] - '0');
                        j++;
                    }

                    if (j == s.Length && currNum <= ulK && currNum >= 1)
                    {
                        dp[i]++;
                        dp[i] %= MODULO;
                    }
                }

                return (int)dp[0];
            }
        }
    }