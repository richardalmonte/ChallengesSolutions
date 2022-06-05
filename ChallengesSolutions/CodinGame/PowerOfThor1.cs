namespace ChallengesSolutions.CodinGame;

public class PowerOfThor1
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position


        var thorX = initialTx;
        var thorY = initialTy;
        // game loop
        while (true)
        {
            int remainingTurns =
                int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            string directionX = "";
            string directionY = "";
            if (thorY > lightY)
            {
                directionY = "N";
                thorY--;
            }
            else if (thorY < lightY)
            {
                directionY = "S";
                thorY++;
            }

            if (thorX > lightX)
            {
                directionX = "W";
                thorX--;
            }
            else if (thorX < lightX)
            {
                directionX = "E";
                thorX++;
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(directionY + directionX);
        }
    }
}