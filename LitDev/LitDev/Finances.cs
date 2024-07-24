//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitDev.Finances;

namespace LitDev
{
    /// <summary>
    /// Lets you ask financial information... 
    /// Created by Abhishek Sathiabalan for LD extension.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDFinances
    {
        static LDFinances()
        {
            Instance.Verify();
        }

        /// <summary>
        /// The API key to use for this API.
        /// You need to get an api key from
        /// https://api.tiingo.com/documentation/general/overview
        /// </summary>
        public static Primitive Key
        {
            get { return Engine.key; }
            set { Engine.key = value; }
        }

        /// <summary>
        /// Gets a description of the company.
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <returns>
        ///    A description of the company in the form of an array upon success.
        ///    On failure returns an error message.
        /// </returns>
        public static Primitive Description(Primitive ticker)
        {
            try
            {
                return Engine.GetDescription(ticker).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        /// <summary>
        /// Gets the current price of the company as
        /// reported by the API.
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <returns>
        ///    A price of the company in the form of an array upon success
        ///    and a failure returns FAILED. 
        /// </returns>
        public static Primitive Price(Primitive ticker)
        {
            try
            {
                return Engine.GetRealTimePrice(ticker).ToString();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Gets the Historical stock information for a stock
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <param name="startDate">The start date formatted in YYYY-MM-DD</param>
        /// <param name="endDate">The end date formatted in YYYY-MM-DD</param>
        /// <param name="freq">daily', 'weekly','monthly', 'annually' are the only valid paramaters</param>
        /// <returns>
        ///    A historical price of the company in the form of an array upon success
        ///    and a failure returns FAILED. 
        /// </returns>
        public static Primitive HistoricalPrice(Primitive ticker, Primitive startDate, Primitive endDate,
            Primitive freq)
        {
            try
            {
                Price[] prices = Engine.GetHistoricalPrice(ticker, startDate, endDate, freq);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < prices.Length; i++)
                {
                    sb.AppendFormat("{0}={1};", i + 1, Utilities.ArrayParse( prices[i].ToString() ) );
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

    }
}
