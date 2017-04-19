using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace LIS2017.App_Code
{
    public class Manage
    {
        public static DataSet UserInfo(int user_id)
        {
            return DbHelperSQL.Query("select * from lis_user where user_id ="+ user_id);
        }

        public static int UserPasswordModify(int user_id, string userpassword)
        {
            return DbHelperSQL.ExecuteSql("update lis_user set user_password= N'" + userpassword + "' where user_id = " + user_id);
        }


    }
}