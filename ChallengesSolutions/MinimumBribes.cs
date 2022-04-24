namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "New year chaos" Problem
        /// found at https://www.hackerrank.com/challenges/new-year-chaos/problem
        /// </summary>
        /// <param name="arr"></param>
        //public static string MinimumBribes(List<int> arr)
        //{
        //    int totalBribes = 0;
        //    int bribes = 0;
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        var val = arr[i] - 1;
        //        if (i == val)
        //        {
        //            continue;
        //        }


        //        bribes = Math.Max(bribes, val - i);

        //        totalBribes += bribes;
        //        if (bribes > 2)
        //        {
        //            break;
        //        }
        //        i += bribes;
        //    }

        //    return bribes > 2 ? "Too chaotic" : $"{totalBribes}";
        //}

        public static string MinimumBribes(List<int> arr)
        {
            int bribe = 0;

            bool chaotic = false;
            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] - (i + 1) > 2)
                {
                    chaotic = true;
                    break;
                }

                for (int j = Math.Max(0, arr[i] - 2); j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        bribe++;
                    }
                }
            }

            return chaotic ? "Too chaotic" : $"{bribe}";
        }

    }
}
