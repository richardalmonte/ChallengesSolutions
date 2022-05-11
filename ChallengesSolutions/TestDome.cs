using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ChallengesSolutions
{
    public partial class Problems
    {

        public static int GetSum()
        {
            var sumOfNumbers = (from number in Enumerable.Range(1, 4)
                                group number by number % 2 into setOfNumbers
                                select setOfNumbers.Sum()).Max();

            return sumOfNumbers;
        }

        public static void IntegerToObject()
        {
            int i = 1;
            object number = (object)i;

        }
        enum Turn
        {
            left = 1,
            right
        }


        public static int MinPieces(int[] original, int[] desired)
        {
            int[] newValues = (int[])original.Clone();
            foreach (var n in desired)
            {
                newValues[Array.IndexOf(desired, n)] = original[Array.IndexOf(original, n)];
            }
            return newValues.Length;
        }

        public static int MinPieces_Old(int[] original, int[] desired)
        {
            var originalVariations = GetVariations(original);
            var desiredVariations = GetVariations(desired);
            var pieces = new List<List<int>>();
            foreach (var item in originalVariations)
            {
                var piece = desiredVariations.Where(x => x.SequenceEqual(item));
                var pieceSelection = piece.SelectMany(x => x);
                var piecesSelection = pieces.SelectMany(x => x);
                var intersect = pieceSelection.Intersect(piecesSelection);
                if (!intersect.Any()) pieces.AddRange(piece);
            }

            return pieces.Count();
        }
        private static List<List<int>> GetVariations(int[] numbers)
        {
            var all = new List<List<int>>();
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {

                    var taked = numbers.Skip(j).Take(i).ToList();
                    if (taked.Count() != i) continue;
                    all.Add(taked);
                }
            }
            return all.OrderByDescending(x => x.Count()).ToList();
        }

    }

    public class ContentFilterAttribute : ActionFilterAttribute
    {
        // Write your code here
        // If the action returns ContentResult, it should replace the content with the one where all
        // instances of "john" are replaced with "redacted"
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var contentResult = context.Result as ContentResult;
            if (contentResult == null)
            {
                throw new InvalidOperationException("The action result is not a ContentResult");
            }

            contentResult.Content = contentResult.Content.Replace("john", "redacted");
        }
    }
}
