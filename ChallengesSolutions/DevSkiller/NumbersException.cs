namespace ChallengesSolutions.DevSkiller
{
    public class NumbersException
    {
        public void RemoveAndPrintNumbers()
        {
            var listOfNumbers = new List<int>() { 1, 2, 3, 3, 3, 4 };
            foreach (var num in listOfNumbers)
            {
                if (num == 3)
                {
                    listOfNumbers.Remove(num);
                }
            }

            foreach (var num in listOfNumbers)
            {
                Console.Write($"{num}");
            }
        }

    }
}
