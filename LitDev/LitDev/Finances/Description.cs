using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitDev.Finances
{
    public class Description
    {
        public string name;
        public DateTime startDate;
        public string ticker;
        public string exchangeCode;
        public string description;
        public DateTime endDate;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("name={0};", name);
            sb.AppendFormat("startDate={0};", startDate);
            sb.AppendFormat("ticker={0};", ticker);
            sb.AppendFormat("exchangeCode={0};", exchangeCode);
            sb.AppendFormat("description={0};", description);
            sb.AppendFormat("endDate={0};", endDate);

            return sb.ToString();
        }
    }
}
