using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class OrderItemSubManage
    {
        public static DataSet GetItemSub(string code)
        {
            string sql = string.Format("select * from LIS_ORDER_ITEM_SUB s inner join LIS_GENERAL_ITEM_PROPERTY p on p.ITEM_CODE=s.ITEM_CODE where CODE='{0}'", code);
            return DbHelperSQL.Query(sql);
        }
    }
}