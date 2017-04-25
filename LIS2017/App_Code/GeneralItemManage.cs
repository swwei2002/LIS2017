using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace LIS2017.App_Code
{
    public class GeneralItemManage
    {
        public static int UpdateItem(string itemcode, string itemtype, string name, string shortname, string testmethod, string testtype)
        {
            string sql = string.Format("update LIS_GENERAL_ITEM_PROPERTY set ITEM_TYPE='{1}',NAME='{2}',SHORTNAME='{3}',TEST_METHOD='{4}',TEST_TYPE='{5}' where ITEM_CODE='{0}'", itemcode, itemtype, name, shortname, testmethod, testtype);
            return DbHelperSQL.ExecuteSql(sql);
        }
        public static int AddItem(string itemcode,string itemtype,string name,string shortname,string testmethod,string testtype)
        {
            string sql = string.Format("insert into LIS_GENERAL_ITEM_PROPERTY(ITEM_CODE,ITEM_TYPE,NAME,SHORTNAME,TEST_METHOD,TEST_TYPE,RESULT_TYPE,DISPLAY_PRECISION,ROUND_FLG,CHECK_FLG,DELTA_CHK_FLG,DELTA_CHK_RATE) values('{0}','{1}','{2}','{3}','{4}','{5}','S','0','0','1','0','0')", itemcode, itemtype, name, shortname, testmethod, testtype);
            return DbHelperSQL.ExecuteSql(sql);
        }
        public static int DeleteItemByItemCode(string itemcode)
        {
            string sql = string.Format("delete from LIS_GENERAL_ITEM_PROPERTY where ITEM_CODE='{0}'", itemcode);
            return DbHelperSQL.ExecuteSql(sql);
        }
        public static DataSet GetItemListByTestType(string type)
        {
            string sql = string.Format("select * from LIS_GENERAL_ITEM_PROPERTY where TEST_TYPE='{0}'",type);
            return DbHelperSQL.Query(sql);
        }

        public static DataSet GetItemListByTestType(string type,int start,int end)
        {
            string sql = string.Format("select * from (select *,ROW_NUMBER () over (order by ITEM_CODE) as ROWNO from LIS_GENERAL_ITEM_PROPERTY where TEST_TYPE='{0}') tmp where ROWNO between {1} and {2}", type,start,end);
            return DbHelperSQL.Query(sql);
        }

        public static int GetItemListCountByTestType(string type)
        {
            string sql = string.Format("select count(*) from LIS_GENERAL_ITEM_PROPERTY where TEST_TYPE='{0}'", type);
            return (int)DbHelperSQL.GetSingle(sql);
        }

        public static DataSet GetItemByItemCode(string itemcode)
        {
            string sql = string.Format("select * from LIS_GENERAL_ITEM_PROPERTY where ITEM_CODE='{0}'", itemcode);
            return DbHelperSQL.Query(sql);
        }
    }
}