using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Order
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                //Response.Redirect("../Login.aspx?link_from=Order/OrderList.aspx");
            }

            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            //2个rpt以及分页

            //未完善

            int pageSize = AspNetPager1.PageSize;
            int pageNo = AspNetPager1.CurrentPageIndex - 1;
            int start = pageNo * pageSize + 1;
            int end = (pageNo + 1) * pageSize;

            DataSet ds = LIS2017.App_Code.Order.OrderList("未完善", start, end);
            AspNetPager1.RecordCount = LIS2017.App_Code.Order.OrderCountByStatus("未完善");
            AspNetPager1.CustomInfoHTML = "记录总数：<b>" + AspNetPager1.RecordCount.ToString() + "</b>";
            rptNoInfo.DataSource = ds;
            rptNoInfo.DataBind();

            //所有记录

            int pageSize2 = AspNetPager2.PageSize;
            int pageNo2 = AspNetPager2.CurrentPageIndex - 1;
            int start2 = pageNo2 * pageSize2 + 1;
            int end2 = (pageNo2 + 1) * pageSize2;

            DataSet ds2 = LIS2017.App_Code.Order.OrderList("", start2, end2);
            AspNetPager2.RecordCount = LIS2017.App_Code.Order.OrderCountByStatus("");
            AspNetPager2.CustomInfoHTML = "记录总数：<b>" + AspNetPager2.RecordCount.ToString() + "</b>";
            rptData.DataSource = ds2;
            rptData.DataBind();


        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        protected void AspNetPager2_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }


    }
}