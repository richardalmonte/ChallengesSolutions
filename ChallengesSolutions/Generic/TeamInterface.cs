using System.Linq;

namespace ChallengesSolutions
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }

    public class Team
    {
        public string teamName;
        public int noOfPlayers;

        public Team(string teamName, int noOfPlayer)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayer;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            var diff = noOfPlayers - count;

            if (diff < 0)
            {
                return false;
            }

            noOfPlayers = diff;

            return true;
        }

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {

            var companyAverage = (from employee in employees
                                  group employee by employee.Company into employeeGroup
                                  orderby employeeGroup.Key
                                  select new
                                  {
                                      employeeGroup.Key,
                                      AvgAge = Convert.ToInt32(employeeGroup.Average(x => x.Age))
                                  }).ToDictionary(x => x.Key, x => x.AvgAge);

            return companyAverage;
        }

    }
    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayer) : base(teamName, noOfPlayer)
        {
        }

        public void ChangeTeamName(string name)
        {
            this.teamName = name;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {

            if (!typeof(Subteam).IsSubclassOf(typeof(Team)))
            {
                throw new Exception("Subteam class should inherit from Team class");
            }

            String str = Console.ReadLine();
            String[] strArr = str.Split();
            string initialName = strArr[0];
            int count = Convert.ToInt32(strArr[1]);
            Subteam teamObj = new Subteam(initialName, count);
            Console.WriteLine("Team " + teamObj.teamName + " created");

            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            teamObj.AddPlayer(count);
            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);


            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            var res = teamObj.RemovePlayer(count);
            if (res)
            {
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            }
            else
            {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }

            str = Console.ReadLine();
            teamObj.ChangeTeamName(str);
            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);
        }
    }
}
