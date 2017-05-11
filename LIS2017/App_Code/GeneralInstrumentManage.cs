using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace LIS2017.App_Code
{
    public class GeneralInstrumentManage
    {
        public static int AddInstrument(string type,string name,string maker,string instrID)
        {
            string sql = string.Format("insert into LIS_GENERAL_INSTRUMENT(TYPE,NAME,MAKER,INSTR_ID) values('{0}','{1}','{2}','{3}')", type, name, maker, instrID);
            return DbHelperSQL.ExecuteSql(sql);
        }
        public static int UpdateInstrByType(string type,string name,string maker,string instrID)
        {
            string sql = string.Format("update LIS_GENERAL_INSTRUMENT set NAME='{0}',MAKER='{1}',INSTR_ID='{2}' where TYPE='{3}'", name, maker, instrID, type);
            return DbHelperSQL.ExecuteSql(sql);
        }
        
        public static DataSet GetInstrumentByType(string type)
        {
            string sql = string.Format("select * from LIS_GENERAL_INSTRUMENT where TYPE='{0}'", type);
            return DbHelperSQL.Query(sql);
        }

        public static DataSet GetInstrument()
        {
            string sql = "select * from LIS_GENERAL_INSTRUMENT";
            return DbHelperSQL.Query(sql);
        }
        public static DataSet GetInstrumentByID(string instrID,int start,int end)
        {
            string sql = "";
            StringBuilder sb = new StringBuilder("select *,ROW_NUMBER () over (order by TYPE) as ROWNO from LIS_GENERAL_INSTRUMENT");
            if (!string.IsNullOrEmpty(instrID))
            {
                sb.Append(" where INSTR_ID='{0}'");
                sql = string.Format(sb.ToString(), instrID);
            }
            else
                sql = sb.ToString();
            sql = string.Format("select * from ({0}) tmp where ROWNO between {1} and {2}", sql, start, end);

            return DbHelperSQL.Query(sql);
        }

        public static int GetInstrumentCountByID(string instrID)
        {
            string sql = "";
            StringBuilder sb = new StringBuilder("select count(*) from LIS_GENERAL_INSTRUMENT");
            if (!string.IsNullOrEmpty(instrID))
            {
                sb.Append(" where INSTR_ID='{0}'");
                sql = string.Format(sb.ToString(), instrID);
            }
            else
                sql = sb.ToString();

            return (int)DbHelperSQL.GetSingle(sql);
        }

        internal static int DeleteInstrByType(string type)
        {
            string sql = string.Format("delete from LIS_GENERAL_INSTRUMENT where TYPE='{0}'", type);
            return DbHelperSQL.ExecuteSql(sql);
        }
    }
}