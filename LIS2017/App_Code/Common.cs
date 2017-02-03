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

namespace LIS2017
{
    public class Common
    {
        public static DataSet UserLogin(string username, string password)
        {
            return DbHelperSQL.Query("select * from oa_user where disable = 0 and user_name = '" + username + "' and user_password = '" + password + "'");
        }

        public static void AddLog(string username, string pagetype, int pageid, string operation)
        {
            DbHelperSQL.ExecuteSql("insert into oa_log (log_username,log_pagetype,log_pageid,log_operation) values ('" + username + "','" + pagetype + "'," + pageid + ",'" + operation + "')");

        }
    }
}