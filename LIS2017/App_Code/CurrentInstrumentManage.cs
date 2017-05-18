using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class CurrentInstrumentManage
    {
        public static DataSet GetInstrByGroupID(string groupID)
        {
            string sql = string.Format("select i.*,c.NAME as C_TEST_TYPE from LIS_CURRENT_INSTRUMENT i left join LIS_CODE_INFO c on i.TEST_TYPE=c.CODE where i.GROUP_ID='{0}' and c.CLASS_ID='C01'", groupID);
            return DbHelperSQL.Query(sql);
        }

        public static int UpdateInstrByInstrID(string instrID,string groupID,string type,string name,string testType,string validFlg,string regment)
        {
            string sql = string.Format("update LIS_CURRENT_INSTRUMENT set GROUP_ID='{0}',TYPE='{1}',NAME='{2}',TEST_TYPE='{3}',VALID_FLG='{4}',REGMENT='{5}' where INSTRUMENT_ID='{6}'"
                                                                          , groupID, type, name, testType, validFlg, regment, instrID);
            return DbHelperSQL.ExecuteSql(sql);
        }

        public static DataSet GetInstrByInstrID(string instrID)
        {
            string sql = string.Format("select * from LIS_CURRENT_INSTRUMENT where INSTRUMENT_ID='{0}'", instrID);
            return DbHelperSQL.Query(sql);
        }
        public static int GetMaxInstrID()
        {
            string sql = string.Format("select max(INSTRUMENT_ID) from LIS_CURRENT_INSTRUMENT");
            object o = DbHelperSQL.GetSingle(sql);
            int res = 0;
            res = o == null ? 0 : (int)o;

            return res;
        }

        public static int AddInstrument(int id,string groupID,string type,string name,string testType,string validFlg,string regment)
        {
            string sql = string.Format("insert into LIS_CURRENT_INSTRUMENT(INSTRUMENT_ID,GROUP_ID,TYPE,NAME,TEST_TYPE,VALIDFLG,REGMENT) values({0},'{1}','{2}','{3}','{4}','{5}','{6}')", id, groupID, type, name, testType, validFlg, regment);

            return DbHelperSQL.ExecuteSql(sql);
        }

        public static int AddInstrument(List<string> sql)
        {
            return DbHelperSQL.ExecuteSqlTran(sql);
        }

        public static string GetAddSql(int id, string groupID, string type, string name, string testType, string validFlg, string regment)
        {
            string sql = string.Format("insert into LIS_CURRENT_INSTRUMENT(INSTRUMENT_ID,GROUP_ID,TYPE,NAME,TEST_TYPE,VALID_FLG,REGMENT) values({0},'{1}','{2}','{3}','{4}','{5}','{6}')", id, groupID, type, name, testType, validFlg, regment);

            return sql;
        }

    }
}