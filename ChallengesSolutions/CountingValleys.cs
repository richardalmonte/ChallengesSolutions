namespace ChallengesSolutions
{
    public partial class Problems
    {
        /// <summary>
        /// HackerRank "Counting Valleys" Problem
        /// found at https://www.hackerrank.com/challenges/counting-valleys/problem
        /// </summary>
        /// <param name="arr"></param>
        public static int CountingValleys(int steps, string path)
        {
            int valleys = 0;
            int seaLevel = 0;
            int maxVal = (int)Math.Pow(10, 6);

            if (!(steps >= 2 && steps <= maxVal) || steps != path.Length)
            {
                return 0;
            }

            foreach (char step in path)
            {
                if (step == 'U')
                {
                    seaLevel++;
                    if (seaLevel == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    seaLevel--;
                }
            }

            return valleys;
        }

    }
}
