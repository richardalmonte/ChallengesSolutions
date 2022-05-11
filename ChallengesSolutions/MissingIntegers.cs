namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// Codility's "Missing Integer" problem
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int MissingInteger_My(int[] a)
        {

            //Write a function:

            // that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

            // For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

            //Given A = [1, 2, 3], the function should return 4.

            //Given A = [−1, −3], the function should return 1.

            //Write an efficient algorithm for the following assumptions:

            //N is an integer within the range[1..100, 000];
            //each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].

            // determine the smallest


            if (a.Length == 0 || a.All(x => x < 1))
            {
                return 1;
            }
            /* This gave an 88% valutaion. Bad Performance */
            var min = a.Min();
            var max = a.Max();
            var valid = Enumerable.Range(1, max).Except(a);

            if (!valid.Any())
            {
                return max + 1;
            }

            return valid.Min();

        }

        /// <summary>
        /// This solution tested 100% OK.
        /// Taken from StackOverlow: https://stackoverflow.com/a/52226420/4822855
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int MissingInteger_StackOverflow(int[] a)
        {
            HashSet<int> found = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    found.Add(a[i]);
                }
            }

            int result = 1;
            while (found.Contains(result))
            {
                result++;
            }

            return result;
        }

        /// <summary>
        /// Solution taken from Medium
        /// https://abbas-ghomi.medium.com/missing-integer-a-codility-experience-in-c-3a1481783389
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MissingInteger_Medium(int[] A)
        {
            int result = 1;

            var a = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToList();

            if (a.Count > 0)
            {
                if (a.First() == 1)
                {
                    if (a.First() == 1 && a.Count == a.Last())
                    {
                        result = a.Last() + 1;
                    }
                    else
                    {
                        result = Enumerable.Range(a.First(), a.Last()).Except(a).First();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// https://stackoverflow.com/a/61777279/4822855
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MissingInteger_Aim100(int[] A)
        {            
            var A2 = Enumerable.Range(1, A.Length + 1);
            return A2.Except(A).First();
        }

        public static int MissingInteger_SimpleCostly(int[] A)
        {
            int missing = 1;
            while (A.Contains(missing))
            {
                missing++;
            }
            return missing;
        }
    }
}
