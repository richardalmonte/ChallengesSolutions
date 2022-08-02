namespace ChallengesSolutions.HackerRank;

public class BetweenTwoSets
{
    public int GetTotalX(List<int> a, List<int> b)
    {
        int totalX = 0;
        int maxA = a.Max();
        int minB = b.Min();
        for (var i = maxA; i <= minB; i++)
        {
            if (Lcm(a, i) && Gcd(b, i))
            {
                totalX++;
            }
        }

        return totalX;
    }

    private static bool Lcm(IEnumerable<int> denoms, int numerator)
    {
        return denoms.All(item => numerator % item == 0);
    }

    private static bool Gcd(IEnumerable<int> numerators, int denom)
    {
        return numerators.All(item => item % denom == 0);
    }
}