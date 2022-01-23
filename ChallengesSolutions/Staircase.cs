namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Staircase" Problem
        /// found at https://www.hackerrank.com/challenges/staircase/problem
        /// </summary>
        /// <param name="arr"></param>
        public static List<string> Staircase(int n)
        {
            List<string> result = new();

            for (int i = 0; i < n; i++)
            {
                string str = String.Empty;
                for (int j = 1; j <= i + 1; j++)
                {
                    str += "#";
                }

                result.Add(str.PadLeft(n));
            }
            return result;
        }

    }
}
