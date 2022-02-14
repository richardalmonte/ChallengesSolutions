namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "New year chaos" Problem
        /// found at https://www.hackerrank.com/challenges/new-year-chaos/problem
        /// </summary>
        /// <param name="arr"></param>
        public static string MinimumBribes(List<int> arr)
        {
            int totalBribes = 0;
            int bribes = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                var val = arr[i] - 1;
                if (i >= val)
                {
                    continue;
                }

                bribes = Math.Max(bribes, val - i);

                totalBribes += bribes;
            }

            return bribes > 2 ? "Too chaotic" : $"{totalBribes}";
        }

    }
}
