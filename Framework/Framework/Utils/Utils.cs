using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utils
{
    class Utils
    {

        public static string getFutureDate(int daysSteps)
        {
            DateTime y = DateTime.Now;
            y = y.AddDays(daysSteps);

            string day = y.Day.ToString();
            string mounth = y.Month.ToString();
            string year = y.Year.ToString();

            string date = mounth + "/" + day + "/" + year;

            return date;
        }
    }
}
