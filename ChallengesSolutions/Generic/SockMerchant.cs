namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Sock Merchant" Problem
        /// found at https://www.hackerrank.com/challenges/sock-merchant/problem
        /// </summary>
        /// <param name="arr"></param>
        public static int SockMerchant(int[] arr)
        {
            Dictionary<int, int> groupedAr = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            int pairs = 0;

            foreach (var g in groupedAr)
            {
                if (g.Value > 1)
                {
                    pairs += (int)(g.Value / 2);
                }
            }

            return pairs;
        }

    }
}
