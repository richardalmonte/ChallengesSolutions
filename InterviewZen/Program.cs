namespace InterviewZen
{
    class Program
    {
        static void Main(string[] args)
        {
            var bl = new BusinessLogic();
            bl.ValidateBusinessEntity();
        }

        public class BusinessLogic
        {
            private readonly DataAccess _dataAccess;
            public int ValidateBusinessEntity()
            {
                // some logic here

                var dal = new DataAccess();
                var someResult = dal.DoSomethingWithDB();

                // some other logic here dependent on someResult
            }
        }

        public class DataAccess
        {
            public void DoSomethingWithDB()
            {
                // some logic here
            }
        }
    }
}