namespace LitDev.Finances
{
    public class FinancialWrapper<T>
    {
        public string symbol;
        public T[] financials;

        public override string ToString()
        {
            return $"symbol={symbol};{financials.ToString()}";
        }
    }
}