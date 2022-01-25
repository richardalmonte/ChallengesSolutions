namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Gaming Array" Problem
        /// found at https://www.hackerrank.com/challenges/an-interesting-game-1/problem
        /// </summary>
        /// <param name="gameSet"></param>
        public static string GamingArray_Timeout(List<int> gameSet)
        {
            var turns = 0;
            while (gameSet.Count > 0)
            {
                var max = gameSet.Max();
                var maxIndex = gameSet.IndexOf(max);
                gameSet.RemoveRange(maxIndex, gameSet.Count - maxIndex);
                turns++;
            }

            return turns % 2 == 0 ? "ANDY" : "BOB";

        }

        /// <summary>
        /// HackerRank "Gaming Array" Problem
        /// found at https://www.hackerrank.com/challenges/an-interesting-game-1/problem
        /// </summary>
        /// <param name="arr"></param>
        public static string GamingArray(List<int> arr)
        {
            var previous = 0;
            var count = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                if (previous < arr[i])
                {
                    count++;
                    previous = arr[i];
                }
            }
            return count % 2 == 0 ? "ANDY" : "BOB";

        }

    }
}
