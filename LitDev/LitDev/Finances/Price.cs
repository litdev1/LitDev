namespace LitDev.Finances
{
    public class Price
    {
        public string symbol;
        public decimal price;

        public override string ToString()
        {
            return $"symbol={symbol};price={price};";
        }
    }
}