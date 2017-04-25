using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class CodeInfoManage
    {
        public static string _TEST_TYPE = "C01";
        public static string _TEST_METHOD = "C04";
        public static DataSet GetInfoByClassID(string classid)
        {
            string sql = string.Format("select * from LIS_CODE_INFO where CLASS_ID='{0}'", classid);
            return DbHelperSQL.Query(sql);
        }
    }
}