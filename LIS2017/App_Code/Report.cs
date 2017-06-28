using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;

namespace LIS2017.App_Code
{
    public class Report
    {
        //report列表
        //type_id = 1 显示标本号list，倒序
        //type_id = 2 待制作的标本号list，倒序（查询LIS_TODAY_ITEM_RESULT，所有项目的audit_person有人）
        //type_id = 3 制作中的列表（test_info中的info_status为制作中）
        //type_id = 4 已完成（test_info中的info_status为已完成）
        public static DataSet ReportList(int type_id)
        {
            if (type_id == 1)
            {
                return DbHelperSQL.Query("select * from LIS_TEST_INFO where disable = 0 order by info_id desc");
            }
            //待制作
            else if (type_id == 2)
            {
                return DbHelperSQL.Query("select * from LIS_TEST_INFO where code in (select distinct(sample_id) from LIS_TODAY_ITEM_RESULT)  and code not in (select distinct(sample_id) from LIS_TODAY_ITEM_RESULT where AUDIT_PERSON is null) and disable = 0 order by info_id desc");
            }
            //制作中
            else if (type_id == 3)
            {
                return DbHelperSQL.Query("select * from LIS_TEST_INFO where disable = 0 and info_status = '制作中' order by info_id desc");
            }
            else if (type_id == 4)
            {
                return DbHelperSQL.Query("select * from LIS_TEST_INFO where disable = 0 and info_status = '已完成' order by info_id desc");
            }
            else
            {
                return DbHelperSQL.Query("");
            }
        }

        public static DataSet ReportDetail(string code)
        {
            return DbHelperSQL.Query("select * from LIS_TODAY_ITEM_RESULT where sample_id = '"+code+"'");
        }
    }
}