namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// TestDome Average Sample
        /// found at https://app.testdome.com/testing/sample/5242
        /// </summary>
        /// <param name="arr"></param>
        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }

        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var uniqueNames = new List<string>();

            names1.Concat(names2).ToList().ForEach(name =>
            {
                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                }
            });

            return uniqueNames.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="sum"></param>
        /// <returns>A Tuple<int,int> containing any of the pairs which sum is <paramref name="sum"/> </returns>
        public static Tuple<int, int>? FindTwoSum(IList<int> list, int sum)
        {
            int max = list.Max();
            for (int i = 0; i < list.Count - 1; i++)
            {
                int first = list[i];

                if (first + max == sum)
                {
                    return new Tuple<int, int>(i, list.IndexOf(max));
                }
                if (first + max < sum)
                {
                    continue;
                }

                for (int j = i + 1; j < list.Count; j++)
                {
                    int second = list[j];
                    if (sum == first + second)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }
            return null;
        }

    }
}
