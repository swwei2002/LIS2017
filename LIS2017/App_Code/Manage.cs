using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace LIS2017.App_Code
{
    public class Manage
    {
        public static DataSet UserDetail(int user_id)
        {
            return DbHelperSQL.Query("select * from lis_user where user_id ="+ user_id);
        }

        public static int UserPasswordModify(int user_id, string userpassword)
        {
            return DbHelperSQL.ExecuteSql("update lis_user set user_password= '" + userpassword + "' where user_id = " + user_id);
        }

        public static int UserAdd(string user_name, string user_password, string real_name, int department_id, int user_access)
        {
            return DbHelperSQL.ExecuteSql("insert into lis_user (user_name,user_password,real_name,department_id,user_accese) values ('" + user_name + "','" + user_password + "',N'" + real_name + "','" + department_id + "','" + user_access + "')");
        }

        public static DataSet UserList()
        {
            return DbHelperSQL.Query("select * from lis_userlistfull order by disable,user_id");
        }

        public static int UserDisable(int user_id,int disable)
        {
            int status = 0;
            if (disable == 0) { status = 1; }
            return DbHelperSQL.ExecuteSql("update lis_user set disable = "+ status + "where user_id = "+ user_id);
        }

        public static int UserModify(int user_id,string user_name,string user_password,string real_name,int department_id,int user_access)
        {
            return DbHelperSQL.ExecuteSql("update lis_user set user_name = '" + user_name+ "',user_password = '" + user_password + "',real_name = N'" + real_name + "',department_id = '" + department_id + "',user_access = '" + user_access + "' where user_id = "+ user_id);
        }


    }
}