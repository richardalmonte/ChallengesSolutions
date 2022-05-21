namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// InterviewBit "Min Jumps Array" Problem
        /// found at https://www.interviewbit.com/problems/min-jumps-array/
        /// </summary>
        /// <param name="arr"></param>
        public static int MinJumps(List<int> array)
        {
            int previous = 0;
            int current = 0;
            int jumps = 0;

            if (array[0] == 0 && array.Count == 1)
            {
                return 0;
            }

            if (array[0] < 1)
            {
                return -1;
            }
            for (int i = 0; i < array.Count; i++)
            {
                if (i > previous)
                {
                    jumps++;
                    previous = current;
                }
                current = Math.Max(current, i + array[i]);
            }

            return jumps < 1 ? -1 : jumps;
        }

    }
}
