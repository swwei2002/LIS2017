using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LIS2017.App_Code
{
    public class GeneralInstrumentItem
    {
        public static DataSet GetItemByType(string type)
        {
            string sql = string.Format("select * from LIS_GENERAL_INSTRUMENT_ITEM where TYPE='{0}'", type);
            return DbHelperSQL.Query(sql);
        }
    }
}