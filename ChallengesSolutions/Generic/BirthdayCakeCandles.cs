namespace ChallengesSolutions
{
    public partial class Problems
    {
        /// <summary>
        /// Complete the 'birthdayCakeCandles' function        
        /// </summary>
        /// <param name="candles"></param>
        /// <returns></returns>
        /// <remarks>You are in charge of the cake for a child's birthday. 
        /// You have decided the cake will have one candle for each year of their total age.
        /// They will only be able to blow out the tallest of the candles.
        /// Count how many candles are tallest.
        /// </remarks>
        public static int BirthdayCakeCandles(List<int> candles)
        {
            if (candles == null || candles.Count < 1)
            {
                return 0;
            }

            var max = candles.Max();
            return candles.Count(c => c >= max);
        }
    }
}
