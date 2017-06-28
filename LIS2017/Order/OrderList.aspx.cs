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

            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {

            //所有记录
            //int pageSize2 = AspNetPager2.PageSize;
            AspNetPager2.PageSize = 100;
            int pageSize = AspNetPager2.PageSize;
            int pageNo = AspNetPager2.CurrentPageIndex - 1;
            int start = pageNo * pageSize + 1;
            int end = (pageNo + 1) * pageSize;

            DataSet ds2 = LIS2017.App_Code.Order.OrderList("", start, end);
            AspNetPager2.RecordCount = LIS2017.App_Code.Order.OrderCountByStatus("");
            AspNetPager2.CustomInfoHTML = "记录总数：<b>" + AspNetPager2.RecordCount.ToString() + "</b>";
            rptData.DataSource = ds2;
            rptData.DataBind();

        }


        protected void AspNetPager2_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        //将选中项添加入带打印
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            //清空代打印
            LIS2017.App_Code.Order.OrderPrintDelete();

            int num = 0;


            foreach (RepeaterItem item in rptData.Items)
            {
                CheckBox cb = (CheckBox)item.FindControl("cbPrint"); //根据控件id获得控件对象，cdDelete是checkBox控件的id  

                if (cb.Checked == true)

                {
                    LIS2017.App_Code.Order.OrderPrintAdd(cb.ToolTip, "", "");
                    num++;
                }

            }


            LTP.Common.MessageBox.Show(this.Page, "成功将" + num + "条标本号放入待打印列表，请操作打印机打印");
            return;
        }
    }
}