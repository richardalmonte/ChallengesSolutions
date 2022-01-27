namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// Codility "Cyclic Rotation" Problem
        /// found at https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
        /// </summary>
        /// <param name="arr"></param>
        public static int[] CyclicRotation(int[] array, int steps)
        {
            var reversed = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int position = (i + steps) % array.Length;
                reversed[position] = array[i];
            }

            return reversed;

        }

    }
}
