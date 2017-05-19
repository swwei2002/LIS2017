using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class OrderSubManage
    {
        public static string GetAddSql(string id,string itemCode,string itemType,string orderItemCode,string depCode,string sName)
        {
            string sql = string.Format("insert into LIS_ORDER_SUB values('{0}','{1}','{2}','{3}','{4}','{5}','0','0',null,null,null,null,null)"
                                        , id, itemCode, itemType, orderItemCode, depCode, sName);
            return sql;
        }

        public static string GetDelSql(string id)
        {
            string sql = string.Format("delete from LIS_ORDER_SUB where ORDER_ID='{0}'", id);
            return sql;
        }

        public static DataSet GetOrderSubByCode(string code)
        {
            string sql = string.Format("select * from LIS_ORDER_SUB where ORDER_ID='{0}'", code);
            return DbHelperSQL.Query(sql);
        }
    }
}