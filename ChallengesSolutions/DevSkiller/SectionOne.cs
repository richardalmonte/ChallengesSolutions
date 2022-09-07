using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesSolutions.DevSkiller
{
    public class ThreadSection
    {
        private static ThreadLocal<int> Counter = new ThreadLocal<int>();

        public static void Execute()
        {
            var firstThread = new Thread(Increment);
            firstThread.Start();
            firstThread.Join();

            var secondThread = new Thread(DecrementByTwo);
            secondThread.Start();
            secondThread.Join();

            Console.WriteLine($"The counter is {Counter}");
        }


        private static void Increment()
        {
            for (int i = 0; i < 100; i++)
            {
                Counter.Value++;
            }

            Console.WriteLine($"The counter after Increment is {Counter}.");
        }

        private static void DecrementByTwo()
        {
            for (int i = 0; i < 100; i++)
            {
                Counter.Value -= 2;
            }

            Console.WriteLine($"The counter after DecrementByTwo is {Counter}.");
        }
    }
}
