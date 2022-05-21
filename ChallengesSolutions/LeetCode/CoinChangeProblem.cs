namespace ChallengesSolutions.LeetCode;

public class CoinChangeProblem
{
    /// <summary>
    /// Solves the coin change problem.
    /// https://leetcode.com/problems/coin-change/
    ///  Return the fewest number of coins that you need to make up that amount.
    ///  If that amount of money cannot be made up by any combination of the coins, return -1.
    ///  Assume that you have an infinite number of each kind of coin.
    /// </summary>
    /// <param name="coins"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public int CoinChange_Copilot(int[] coins, int amount)
    {
        if (amount == 0)
            return 0;

        int[] dp = new int[amount + 1];
        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            dp[i] = int.MaxValue;
            foreach (int coin in coins)
            {
                if (i - coin >= 0 && dp[i - coin] != int.MaxValue)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }

    public int CoinChage_Mine(int[] coins, int amount)
    {
        var sortedCoins = coins;
        Array.Sort(sortedCoins);

        int result = amount;
        int counter = 0;
        for (int i = sortedCoins.Length - 1; i >= 0; i--)
        {
            var multiplier = result / sortedCoins[i];
            counter += multiplier;
            result = result - (multiplier * sortedCoins[i]);
        }


        return result == 0 ? counter : -1;
    }
}