namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Diagonal Difference" problem
        /// Solution using Bitwise Exclusive OR (XOR). Not working on HackerRank
        /// found at https://www.hackerrank.com/challenges/diagonal-difference
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int DiagonalDifference_Bitwise(List<List<int>> arr)
        {

            int diagA = arr[0][0];
            int diagB = arr[0][^1];

            for (int i = 1; i < arr.Count; i++)
            {
                List<int> row = arr[i];

                diagA += row[i];
                diagB += row[^(i + 1)];

            }

            return Math.Abs(diagA - diagB);
        }

        /// <summary>
        /// HackerRank "Diagonal Difference" problem
        /// Solution accepted on HackerRank
        /// found at https://www.hackerrank.com/challenges/diagonal-difference
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int DiagonalDifference_Accepted(List<List<int>> arr)
        {
            int diagA = arr[0][0];
            int diagB = arr[0][arr[0].Count - 1];

            for (int i = 1; i < arr.Count; i++)
            {
                List<int> row = arr[i];

                diagA += row[i];
                diagB += row[row.Count - (i + 1)];

            }

            return Math.Abs(diagA - diagB);
        }

    }
}
