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

        public static List<int> RotLeft(List<int> a, int d)
        {
            //int[] array1 = a.Take(d).Reverse().ToArray();
            //int[] array2 = a.Skip(d).Take(a.Count - d + 1).Reverse().ToArray();
            //return array1.Concat(array2).Reverse().ToList();

            int[] reversed = new int[a.Count];
            var max = a.Count - d;
            for (int i = 0; i < a.Count; i++)
            {
                int position = (max + i) % a.Count;

                reversed[position] = a[i];
            }
            return reversed.ToList();
        }

    }
}
