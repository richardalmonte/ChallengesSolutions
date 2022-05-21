namespace ChallengesSolutions
{
    public class TextInput
    {
        protected string input;

        public virtual void Add(char c)
        {
            input += c;
        }

        public string GetValue()
        {
            return input;
        }
              
    }

}
