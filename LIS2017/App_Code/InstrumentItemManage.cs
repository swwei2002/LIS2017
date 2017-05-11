using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class InstrumentItemManage
    {
        public static int AddItem(List<string> sql)
        {
            return DbHelperSQL.ExecuteSqlTran(sql);
        }
        public static int GetMaxDispSeq(string instrID)
        {
            string sql = string.Format("select max(DISPLAY_SEQ) from LIS_INSTRUMENT_ITEM_PROPERTY where INSTRUMENT_ID='{0}'", instrID);
            object o = DbHelperSQL.GetSingle(sql);

            return o == null ? 0 : (short)o;
        }

        public static int GetMaxPrintSeq(string instrID)
        {
            string sql = string.Format("select max(PRINT_SEQ) from LIS_INSTRUMENT_ITEM_PROPERTY where INSTRUMENT_ID='{0}'", instrID);
            object o = DbHelperSQL.GetSingle(sql);

            return o == null ? 0 : (short)o;
        }

        public static string GetAddSql(string instrID,string itemCode,string type,int disSeq,int printSeq)
        {
            string sql = string.Format("insert into LIS_INSTRUMENT_ITEM_PROPERTY select '{0}',ii.ITEM_CODE,ITEM_TYPE,NAME,SHORTNAME,MARK,RESULT_TYPE,TEST_METHOD,TEST_TYPE,{2},{3},0,0,CHANNEL_NO,UNIT,INSTRUMENT_UNIT,DISPLAY_PRECISION,ROUND_FLG,CONVERSION_RATE,CONVERSION_PLUS,CHECK_FLG,OFFICIAL_CODE,EXPLAIN,DELTA_CHK_FLG,DELTA_CHK_RATE,null,null,null,null,null,null,null,null from LIS_GENERAL_INSTRUMENT_ITEM ii inner join LIS_GENERAL_ITEM_PROPERTY ip on ii.ITEM_CODE=ip.ITEM_CODE where ii.ITEM_CODE='{1}' and TYPE='{4}'", instrID, itemCode,disSeq,printSeq, type);
            return sql;
        }

        public static string GetAddSql(string instrID, string itemCode, int disSeq, int printSeq)
        {
            string sql = string.Format("insert into LIS_INSTRUMENT_ITEM_PROPERTY select '{0}',ITEM_CODE,ITEM_TYPE,NAME,SHORTNAME,MARK,RESULT_TYPE,TEST_METHOD,TEST_TYPE,{2},{3},0,0,'',UNIT,INSTRUMENT_UNIT,DISPLAY_PRECISION,ROUND_FLG,1,0,CHECK_FLG,OFFICIAL_CODE,EXPLAIN,DELTA_CHK_FLG,DELTA_CHK_RATE,null,null,null,null,null,null,null,null from LIS_GENERAL_ITEM_PROPERTY  where ITEM_CODE='{1}'", instrID, itemCode, disSeq, printSeq);
            return sql;
        }

        public static DataSet GetItemByInstrID(string instrID)
        {
            string sql = string.Format("select * from LIS_INSTRUMENT_ITEM_PROPERTY where INSTRUMENT_ID='{0}'", instrID);
            return DbHelperSQL.Query(sql);
        }

        public static int DeleteItemByItemCode(string instrID,string itemCode)
        {
            string sql = string.Format("delete from LIS_INSTRUMENT_ITEM_PROPERTY where INSTRUMENT_ID='{0}' and ITEM_CODE='{1}'", instrID,itemCode);
            return DbHelperSQL.ExecuteSql(sql);
        }
    }
}