namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Number Line Jumps (Kangaroo)" Problem
        /// found at https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="arr"></param>
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            var x = x2 - x1;
            var v = v2 - v1;
            return x * v < 0 && x % v == 0 ? "YES" : "NO";
        }

    }
}
