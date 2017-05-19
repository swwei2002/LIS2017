using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace LIS2017.App_Code
{
    public class TestInfoManage
    {
        public static DataSet GetTestInfoByDateRange(string begin,string end)
        {
            StringBuilder sb = new StringBuilder("select * from LIS_TEST_INFO where disable=0");
            if (!string.IsNullOrEmpty(begin))
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(begin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    sb.Append(" and create_date>='" + dt.ToString("yyyy-MM-dd") + "'");
                }
                catch
                {

                }
            }

            if (!string.IsNullOrEmpty(end))
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(end, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    dt = dt.AddDays(1);
                    sb.Append(" and create_date<'" + dt.ToString("yyyy-MM-dd") + "'");
                }
                catch
                {

                }
            }

            return DbHelperSQL.Query(sb.ToString());
        }
    }
}