namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Jumping on the Clouds" Problem
        /// found at https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        /// </summary>
        /// <param name="arr"></param>
        public static int JumpingOnClouds(List<int> input)
        {
            int i = 0;
            int jumps = 0;
            while (i < input.Count - 1)
            {
                if (i + 2 < input.Count && input[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }
                jumps++;
            }

            return jumps;
        }

    }
}
