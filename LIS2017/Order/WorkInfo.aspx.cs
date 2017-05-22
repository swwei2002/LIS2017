using LIS2017.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIS2017.Order
{
    public partial class WorkInfo : System.Web.UI.Page
    {
        protected string _html = "";
        protected int _col=5;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {
            StringBuilder sb = new StringBuilder();
            DataSet ds = TestGroupManage.GetTestGroupByType("1");
            DataRow[] group = ds.Tables[0].Select("GROUP_ID <> '010'");
            int colSpan = _col + 1;
            foreach(DataRow dr in group)
            {
                string groupID = dr["GROUP_ID"] as string;
                string name = dr["NAME"] as string;
                DataSet subs = OrderSubManage.GetUnTestByGroupID(groupID);
                if (subs.Tables[0].Rows.Count > 0)
                {
                    sb.AppendLine("<div class='split'>");
                    sb.AppendLine("<table border='0' width='600px' align='center'>");
                    sb.AppendLine("<thead style='font-weight:bold'>");
                    sb.AppendLine("<tr><td colspan='" + colSpan + "' align='center' style='font-weight:bold;'>" + name + "</td></tr></thead>");
                    sb.AppendLine("<tbody style='text-align:left'>");

                    DataSet orderIDs = OrderSubManage.GetUnTestOrderIDByGroupID(groupID);
                    
                    foreach (DataRow orderID in orderIDs.Tables[0].Rows)
                    {
                        int i = 1;

                        string id = orderID["ORDER_ID"] as string;
                        //string seriesName = orderID["SERIES_NAME"] as string;
                        //string showName = string.Format("{0}{1}", id, seriesName == null ? "" : seriesName);
                        DataRow[] rs = subs.Tables[0].Select("ORDER_ID='" + id + "'");
                        int end = rs.Length;
                        int span = Convert.ToInt16(Math.Ceiling(end / (_col * 1.0)));

                        sb.AppendLine("<tr><td width='20%' rowspan='" + span + "' style='word-wrap:break-word;word-break:break-all;'>" + id + "</td>");
                        foreach (DataRow r in rs)
                        {

                            if ((i % _col) == 1 && i !=1) sb.AppendLine("<tr>");
                            
                            sb.AppendLine("<td>" + r["SHORTNAME"] + "</td>");

                            if (i % _col == 0)  sb.AppendLine("</tr>");

                            i++;
                        }
                        sb.Append("</tr>");
                        sb.Append("<tr><td colspan='" + colSpan + "' style='color:black'><hr/></td></tr>");
                    }
                    sb.AppendLine("</tbody>");
                    sb.AppendLine("</table>");
                    sb.AppendLine("</div>");
                }
            }

            _html = sb.ToString();
        }
    }
}