using System.ComponentModel.DataAnnotations;

namespace ChallengesSolutions.CodinGame;

public class TheDescentProblem
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            var index = 0;
            var height = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                
                if (mountainH > height)
                {
                    index = i;
                    height = mountainH;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(index); // The index of the mountain to fire on.
        }
    }
}