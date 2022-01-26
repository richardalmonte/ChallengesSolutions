namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// HackerRank "Grading Students" Problem
        /// found at https://www.hackerrank.com/challenges/grading/problemproblem
        /// </summary>
        /// <param name="arr"></param>
        public static List<int> GradingStudents(List<int> grades)
        {
            // HackerLand University has the following grading policy.
            // * Every student receives a grade in the inclusive range from 0 to 100.
            // * any grade less than 40 is a falling grade.

            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];
                if (grade < 38)
                {
                    continue;
                }

                int nextMultiple = Convert.ToInt32(Math.Floor((decimal)grade / 5) * 5);

                if (grade % 5 != 0)
                {
                    nextMultiple += 5;
                }

                grades[i] = (nextMultiple - grade < 3) ? nextMultiple : grade;
            }

            return grades;
        }

    }
}
