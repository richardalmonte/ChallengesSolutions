using System;
using System.Linq;

namespace InterviewZen
{
    public class FizzBuzz
    {
        public static void PrintFizzBuzz()
        {
            var numbers = Enumerable.Range(1, 100);
            foreach (var number in numbers)
            {
                Console.WriteLine(GetFizzBuzz(number));
            }
        }

        public static string GetFizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
        
        // Write a method to parse a time in the format "hh:mm:ss.00" and return the number of seconds since midnight.
        // E.g. for 12:34:56.789 it should return 4529.789
        public static double GetSecondsSinceMidnight(string time)
        {
            var parts = time.Split(':');
            var hours = int.Parse(parts[0]);
            var minutes = int.Parse(parts[1]);
            var seconds = int.Parse(parts[2].Split('.')[0]);
            var milliseconds = int.Parse(parts[2].Split('.')[1]);
            return hours * 3600 + minutes * 60 + seconds + milliseconds / 1000.0;
        }

        public  static bool IsAnagram(string first, string second)
        {
            var firstCharCount = new int[26];
            var secondCharCount = new int[26];
            foreach (var c in first)
            {
                firstCharCount[c - 'a']++;
            }
            foreach (var c in second)
            {
                secondCharCount[c - 'a']++;
            }
            for (var i = 0; i < 26; i++)
            {
                if (firstCharCount[i] != secondCharCount[i])
                {
                    return false;
                }
            }
            return true;
        }

    }

    public class WorkItemProcessor
    {
        // Give a WorkItem producer, write a program to:
        // 1) process WorkItems as quickly as possible (there's no dependency between WorkItems).
        // Processing them means simply to append the string " processed" to their Text.
        // 2) Forward each processed WorkItem to a final receiver object that prints out their
        // Text and counts them.
        
        public  void ProcessWorkItems(IWorkItemProducer producer, IWorkItemReceiver receiver)
        {
            var workItems = producer.GetWorkItems();
            foreach (var workItem in workItems)
            {
                workItem.Text += " processed";
                receiver.Receive(workItem);
            }
        }
    }
    public class WorkItem
    {
        public  string Text {get; set;}
    }
    
    
}