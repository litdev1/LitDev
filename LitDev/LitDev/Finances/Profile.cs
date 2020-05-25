using System.Text;

namespace LitDev.Finances
{
    /// <summary>
    /// Information about a companies profile
    /// </summary>
    public class Profile
    {
        public decimal price;
        public decimal beta;
        public int volAvg;
        public double mktCap;
        public decimal lastDiv;
        public string range;
        public decimal changes;
        public string changesPercentage;
        public string companyName;
        public string exchange;
        public string industry;
        public string description;
        public string ceo;
        public string sector;
        public string image;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"price={price};");
            sb.Append($"beta={beta};");
            sb.Append($"volumeAverage={volAvg};");
            sb.Append($"marketCap={mktCap};");
            sb.Append($"lastDiv={lastDiv};");
            sb.Append($"range={range};");
            sb.Append($"changes={changes};");
            sb.Append($"changesPercentage={changesPercentage};");
            sb.Append($"companyName={companyName};");
            sb.Append($"exchange={exchange};");
            sb.Append($"industry={industry};");
            sb.Append($"description={description};");
            sb.Append($"ceo={ceo};");
            sb.Append($"sector={sector};");
            sb.Append($"image={image};");
            return sb.ToString();
        }
    }
}