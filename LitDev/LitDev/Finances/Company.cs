namespace LitDev.Finances
{
    public class Company
    {
        public string symbol;
        public Profile profile;

        public override string ToString()
        {
            return $"symbol={symbol};{profile.ToString()}";
        }
    }
}