using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class CompanyManage
    {
        public static DataSet GetCompany()
        {
            string sql = "select * from LIS_COMPANY where DISABLE=0";
            return DbHelperSQL.Query(sql);
        }
    }
}