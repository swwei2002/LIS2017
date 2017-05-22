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

        public static DataSet GetUnTestByGroupID(string groupID)
        {
            string sql = string.Format("select os.*,ir.SAMPLE_ID,ir.ORIGINAL_RESULT,ip.TEST_TYPE,tg.NAME,ip.SHORTNAME from LIS_ORDER_SUB os left join LIS_TODAY_ITEM_RESULT ir on os.ORDER_ID=ir.SAMPLE_ID and os.ITEM_CODE=ir.ITEM_CODE inner join LIS_GENERAL_ITEM_PROPERTY ip on ip.ITEM_CODE=os.ITEM_CODE inner join LIS_TEST_GROUP tg on tg.TEST_TYPE like '%'+ip.TEST_TYPE+'%' where tg.GROUP_ID='{0}' and (ir.ORIGINAL_RESULT is null or ir.ORIGINAL_RESULT='') order by os.ORDER_ID,os.ITEM_CODE", groupID);
            return DbHelperSQL.Query(sql);
        }

        public static DataSet GetUnTestOrderIDByGroupID(string groupID)
        {
            string sql = string.Format("select distinct os.ORDER_ID from LIS_ORDER_SUB os left join LIS_TODAY_ITEM_RESULT ir on os.ORDER_ID=ir.SAMPLE_ID and os.ITEM_CODE=ir.ITEM_CODE inner join LIS_GENERAL_ITEM_PROPERTY ip on ip.ITEM_CODE=os.ITEM_CODE inner join LIS_TEST_GROUP tg on tg.TEST_TYPE like '%'+ip.TEST_TYPE+'%' where tg.GROUP_ID='{0}' and (ir.ORIGINAL_RESULT is null or ir.ORIGINAL_RESULT='') order by os.ORDER_ID", groupID);
            return DbHelperSQL.Query(sql);
        }

        public static DataSet GetUnAuditByUserID(int userID)
        {
            string sql = string.Format("select s.*,p.NAME,p.SHORTNAME from LIS_USER u inner join LIS_TEST_GROUP g on u.department_id=g.GROUP_ID inner join LIS_GENERAL_ITEM_PROPERTY p on g.TEST_TYPE like '%'+p.TEST_TYPE+'%' inner join LIS_ORDER_SUB s on s.ITEM_CODE=p.ITEM_CODE where u.user_id={0} and s.AUDIT_FLG='0'", userID);

            return DbHelperSQL.Query(sql);
        }

        public static DataSet GetUnAuditOrderIDByUserID(int userID)
        {
            string sql = string.Format("select distinct s.ORDER_ID from LIS_USER u inner join LIS_TEST_GROUP g on u.department_id=g.GROUP_ID inner join LIS_GENERAL_ITEM_PROPERTY p on g.TEST_TYPE like '%'+p.TEST_TYPE+'%' inner join LIS_ORDER_SUB s on s.ITEM_CODE=p.ITEM_CODE where u.user_id={0} and s.AUDIT_FLG='0'", userID);

            return DbHelperSQL.Query(sql);
        }

        public static int UpdateAuditFlg(int userID,string orderID)
        {
            string sql = string.Format("update s set s.AUDIT_FLG='1' from LIS_USER u inner join LIS_TEST_GROUP g on u.department_id=g.GROUP_ID inner join LIS_GENERAL_ITEM_PROPERTY p on g.TEST_TYPE like '%'+p.TEST_TYPE+'%' inner join LIS_ORDER_SUB s on s.ITEM_CODE=p.ITEM_CODE where u.user_id={0} and s.AUDIT_FLG='0' and s.ORDER_ID='{1}'", userID, orderID);

            return DbHelperSQL.ExecuteSql(sql);
        }
    }
}