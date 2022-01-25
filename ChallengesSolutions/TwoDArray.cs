namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "2D Array - DS" Problem
        /// found at https://www.hackerrank.com/challenges/2d-array/problem
        /// </summary>
        /// <param name="arr"></param>
        public static int HourglassSum(List<List<int>> arr)
        {
            int max = int.MinValue;

            // On HackerRank site the working solution is using the loop until <= 3 | < 4. Don't know why
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int sum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2]; //First row
                    sum += arr[row + 1][col + 1]; // Second row. Just one element.
                    sum += arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2]; //Third row

                    max = Math.Max(max, sum);
                }
            }
            return max;
        }

    }
}
