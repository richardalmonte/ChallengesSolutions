namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// Codility "Binary Gap" Problem
        /// found at https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
        /// </summary>
        /// <param name="arr"></param>
        public static int BinaryGap(int n)
        {
            var binArray = Convert.ToString(n, 2).ToCharArray();

            int lastPosition = 0;
            int gapSize = 0;

            for (int i = 0; i < binArray.Length; i++)
            {
                if (binArray[i] == '0')
                {
                    continue;
                }

                int diff = i - lastPosition;
                if (diff > gapSize)
                {
                    gapSize = diff - 1;
                }
                lastPosition = i;
            }

            return gapSize;
        }

    }
}
