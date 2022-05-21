namespace ChallengesSolutions
{
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (int.TryParse(c.ToString(), out int i))
            {
                this.input += c;
            }
        }
    }

}
