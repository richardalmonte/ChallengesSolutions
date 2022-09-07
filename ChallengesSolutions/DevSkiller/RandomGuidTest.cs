namespace ChallengesSolutions.DevSkiller;

public class RandomGuid
{
    private static List<string> _randomGuids = new();

    public static void Execute()
    {
        var tasks = new List<Task>();
        for (int i = 0; i < 10; i++)
        {
            tasks.Add(Task.Run(() => GenerateRandomGuid()));
        }

        Task.WaitAll(tasks.ToArray());
        Console.WriteLine($"RandomGuids count = {_randomGuids.Count}");

    }

    private static void GenerateRandomGuid()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(new Random().Next(1, 10));
            _randomGuids.Add(new Guid().ToString());
        }
    }
}