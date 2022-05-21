namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Apples and Oranges" Problem
        /// found at https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// </summary>
        /// <param name="arr"></param>
        public static List<int> CountApplesAndOranges(int houseStart, int houseEnd, int appleTreeLocation, int orangeTreeLocation, List<int> apples, List<int> oranges)
        {
            /*
             * Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.
             *                 
             * In the diagram below:
             * The red region denotes the house, where  is the start point, and  is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
                Assume the trees are located on a single point, where the apple tree is at point , and the orange tree is at point .
                When a fruit falls from its tree, it lands  units of distance from its tree of origin along the -axis. *A negative value of  means the fruit fell  units to the tree's left, and a positive value of  means it falls  units to the tree's right. *
             * */

            int applesCount = apples.Count(x => (appleTreeLocation + x) >= houseStart && (appleTreeLocation + x) <= houseEnd);
            int orangesCount = oranges.Count(x => (orangeTreeLocation + x) >= houseStart && (orangeTreeLocation + x) <= houseEnd);

            return new List<int>() { applesCount, orangesCount };
        }

    }
}
