using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Order
{
    public partial class OrderComplete : System.Web.UI.Page
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
            AspNetPager2.PageSize = 100;
            int pageSize2 = AspNetPager2.PageSize;
            int pageNo2 = AspNetPager2.CurrentPageIndex - 1;
            int start2 = pageNo2 * pageSize2 + 1;
            int end2 = (pageNo2 + 1) * pageSize2;

            DataSet ds2 = LIS2017.App_Code.Order.OrderList("未完善", start2, end2);
            AspNetPager2.RecordCount = LIS2017.App_Code.Order.OrderCountByStatus("未完善");
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

        //单条删除
        protected void ImageButtonDelete_Click(object sender, ImageClickEventArgs e)
        {
            string itemCode = ((ImageButton)sender).CommandArgument;
            int i = LIS2017.App_Code.Order.OrderDisable(int.Parse(itemCode));
            //int i = GeneralItemManage.DeleteItemByItemCode(itemCode);
            BindData();
        }

        //批量删除
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int num = 0;


            foreach (RepeaterItem item in rptData.Items)
            {
                CheckBox cb = (CheckBox)item.FindControl("cbPrint"); //根据控件id获得控件对象，cdDelete是checkBox控件的id  

                if (cb.Checked == true)

                {
                    //LIS2017.App_Code.Order.OrderPrintAdd(cb.ToolTip, "", "");
                    LIS2017.App_Code.Order.OrderDisable(int.Parse(cb.ToolTip));
                    num++;
                }

            }

            BindData();
        }
    }
}