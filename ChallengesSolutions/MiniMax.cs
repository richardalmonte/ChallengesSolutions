namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Mini-Max Sum" Problem
        /// found at https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// </summary>
        /// <param name="arr"></param>
        public static long[] MiniMaxSum(int[] arr)
        {
            /* Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
             * Then print the respective minimum and maximum values as a single line of two space-separated long integers.            
             */
            Array.Sort(arr);

            var min = arr.Take(arr.Length - 1).Sum(x => Convert.ToInt64(x));
            var max = arr.Skip(1).Sum(x => Convert.ToInt64(x));
            return new long[] { min, max };
        }

    }
}
