using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBatch
{
    class Utils
    {

        internal static DateTime GetDateFromString(String dateString)
        {
            return DateTime.ParseExact(dateString, "yyyyddMM", System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}
