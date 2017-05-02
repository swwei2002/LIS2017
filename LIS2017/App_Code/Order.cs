using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;

namespace LIS2017.App_Code
{
    public class Order
    {
        public static DataSet OrderDetail(int info_id)
        {
            return DbHelperSQL.Query("select * from LIS_TEST_INFO where info_id =" + info_id);
        }

        //公司id，公司名，生成数量
        public static int OrderAdd(string company_id,string company_name,int number)
        {
            //根据company_id查出该类的max号码+1，赋值
            int code;
            int gen_num = 0;

            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query("select max(code) as code from LIS_TEST_INFO where code like '"+company_id+ DateTime.Now.Year.ToString().Substring(2, 2) + "%'");

            if (ds == null || ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Rows[0]["code"].ToString() == "" || ds.Tables[0].Rows[0]["code"].ToString() == null)
            {
                //为空时进行处理(170001)
                code = int.Parse(DateTime.Now.Year.ToString().Substring(2, 2) + "0001");         
            }
            else
            {
                //不为空时处理(1700XX+1)
                code = int.Parse(ds.Tables[0].Rows[0]["code"].ToString().Substring(2, 6))+1;
            }

            for (int i = 0; i < number; i++)
            {
                //DbHelperSQL.ExecuteSql("insert into LIS_TEST_INFO (code,company_id,company_name) values (N'" +company_id + code.ToString() + "',N'" + company_id + "',N'" + company_name + "'");
                string sql = string.Format("insert into LIS_TEST_INFO (code,company_id,company_name) values('{0}','{1}','{2}')", company_id+code, company_id,company_name);
                DbHelperSQL.ExecuteSql(sql);
                code++;
                gen_num++;
            }

            //return company_id + code.ToString();
            return gen_num;
        }

        public static int OrderModify(int info_id,string company_id,string company_name,string sample_type,string dis_code,string disease,string name,string gender,string age,string card_id,string info_status)
        {
            return DbHelperSQL.ExecuteSql("update LIS_TEST_INFO set company_id = '" + company_id + "',company_name = '" + company_name + "',sample_type = '" + sample_type + "',dis_code = '" + dis_code + "',disease = '" + disease + "',name = '" + name + "',gender = '" + gender + "',age = '" + age + "',card_id = '" + card_id + "',info_status = '" + info_status + "' where info_id = " + info_id);
        }

        public static DataSet OrderList(string info_status,int start,int end)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from (select *,ROW_NUMBER () over (order by info_id) as ROWNO from LIS_TEST_INFO  where disable = 0 ");

            if (info_status != "")
            {
                sb.Append("  and info_status=N'"+info_status+"' ");
            }
            sb.Append(") tmp where ROWNO between "+ start + " and " + end);

            return DbHelperSQL.Query(sb.ToString());
        }

        public static int OrderCountByStatus(string info_status)
        {
            string sql = string.Format("select count(*) from LIS_TEST_INFO where disable = 0 and info_status='{0}'", info_status);
            return (int)DbHelperSQL.GetSingle(sql);
        }

    }
}