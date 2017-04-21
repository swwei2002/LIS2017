using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace LIS2017.App_Code
{
    public class Common
    {
        public static DataSet UserLogin(string username, string password)
        {
            return DbHelperSQL.Query("select * from lis_user where disable = 0 and user_name = '" + username + "' and user_password = '" + password + "'");
        }

        public static void AddLog(int user_id, string page_name, int page_id, string operation)
        {
            DbHelperSQL.ExecuteSql("insert into lis_log (user_id,page_name,page_id,log_operation) values ('" + user_id + "','" + page_name + "'," + page_id + ",'" + operation + "')");
        }

        //根据一个pre_id查询此id下的子id
        public static DataSet TypeInfoByPreId(int pre_type_id)
        {
            return DbHelperSQL.Query("select * from lis_typelist where disable = 0 and pre_type_id = " + pre_type_id + " order by order_num");
        }

        public static DataSet TypeInfoById(int type_id)
        {
            return DbHelperSQL.Query("select * from lis_typelist where disable = 0 and type_id = " + type_id + " order by order_num");
        }


    }
}