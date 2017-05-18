using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class TestGroupManage
    {
        public static DataSet GetTestGroupByType(string groupType)
        {
            string sql = string.Format("select * from LIS_TEST_GROUP where GROUP_TYPE='{0}' and DISABLE='0'",groupType);
            return DbHelperSQL.Query(sql);
        }
    }
}