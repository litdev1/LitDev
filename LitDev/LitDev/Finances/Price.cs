using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LitDev.Finances
{
    /**
     * The price class is used to represent both historical and realtime stock
     * information.
     */
    public class Price
    {
        public DateTime date;
        public decimal close;
        public decimal high;
        public decimal low;
        public decimal open;
        public double volume;

        public decimal adjClose;
        public decimal adjHigh;
        public decimal adjLow;
        public decimal adjOpen;
        public decimal adjVolume;

        public decimal divCash;
        public decimal splitFactor;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("date={0};", date.ToString());
            sb.AppendFormat("close={0};", close);
            sb.AppendFormat("high={0};", high);
            sb.AppendFormat("low={0};", low);
            sb.AppendFormat("open={0};", open);
            sb.AppendFormat("volume={0};", volume);

            sb.AppendFormat("adjClose={0};", adjClose);
            sb.AppendFormat("adjHigh={0};", adjHigh);
            sb.AppendFormat("adjLow={0};", adjLow);
            sb.AppendFormat("adjOpen={0};", adjOpen);
            sb.AppendFormat("adjVolume={0};", adjVolume);

            sb.AppendFormat("divCash={0};", divCash);
            sb.AppendFormat("splitFactor={0};", splitFactor);
            return sb.ToString();
;       }
    }
}
