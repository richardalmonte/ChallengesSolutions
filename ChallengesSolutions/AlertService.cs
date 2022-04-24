namespace ChallengesSolutions
{
    public class AlertService
    {
        private readonly IAlertDAO storage;

        public AlertService(IAlertDAO alertDAO)
        {
            storage = alertDAO;
        }

        public Guid RaiseAlert()
        {
            return this.storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return this.storage.GetAlert(id);
        }
    }


}
