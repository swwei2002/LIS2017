using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class OrderItemManage
    {
        public static DataSet GetOrderItem(string seriesCode,string type,string test_type)
        {
            string sql = "select * from LIS_ORDER_ITEM i left join LIS_GENERAL_ITEM_PROPERTY p on i.ITEM_LIST=p.ITEM_CODE where 1=1";
            if (!string.IsNullOrEmpty(seriesCode)) sql += string.Format("and SERIES_DEP_CODE='{0}'", seriesCode);
            if (!string.IsNullOrEmpty(type)) sql += string.Format("and TYPE='{0}'", type);
            if (!string.IsNullOrEmpty(test_type)) sql += string.Format("and TEST_TYPE='{0}'", test_type);

            return DbHelperSQL.Query(sql);
        }
    }
}