namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Plus Minus" Problem
        /// found at https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        /// <param name="arr"></param>
        public static string PlusMinus(int[] arr)
        {
            int count = arr.Length;

            List<double> list = new()
            {
                arr.Count(x => x > 0),
                arr.Count(x => x < 0),
                arr.Count(x => x == 0)
            };

            string result = string.Empty;
            foreach (double num in list)
            {
                double eq = num / count;
                // This is the output when working on HackerRank site. Do not forget the return of the method (void).
                //Console.WriteLine(FormattableString.Invariant($"{eq:F6}")); 
                result += FormattableString.Invariant($"{eq:F6};"); //Use FormattableString.Invariant to avoid issues when using different cultures.
            }

            return result.TrimEnd(';');
        }

    }
}
