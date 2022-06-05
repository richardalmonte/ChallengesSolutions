namespace ChallengesSolutions.CodinGame;

public class Temperatures
{
    // Find the closest temperature to 0;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[]
            inputs = Console.ReadLine()
                .Split(' '); // A string with the temperatures expressed as integers ranging from -273 to 5526

        int closestToZero = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526

            int pos = Math.Abs(temp);
            if (pos < Math.Abs(closestToZero))
            {
                closestToZero = temp;
            }
            else if (pos == Math.Abs(closestToZero))
            {
                closestToZero = Math.Max(closestToZero, temp);
            }
        }

        Console.WriteLine(closestToZero == int.MaxValue ? 0 : closestToZero);
    }
}