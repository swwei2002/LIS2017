using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("../Login.aspx?link_from=Manage/UserList.aspx");
            }

            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            DataSet ds = new DataSet();
            ds = LIS2017.App_Code.Manage.UserList();
            rptData.DataSource = ds;
            rptData.DataBind();

            //翻页稍后做

        }

        private void InitGeneralItem()
        {
            int pageSize = AspNetPager1.PageSize;
            int pageNo = AspNetPager1.CurrentPageIndex - 1;
            int start = pageNo * pageSize + 1;
            int end = (pageNo + 1) * pageSize;
            //string code = DropDownListType.SelectedValue;

            //DataSet ds = GeneralItemManage.GetItemListByTestType(code, start, end);
            //AspNetPager1.RecordCount = GeneralItemManage.GetItemListCountByTestType(code);
            //AspNetPager1.CustomInfoHTML = "记录总数：<b>" + AspNetPager1.RecordCount.ToString() + "</b>";
            //RepeaterItem.DataSource = ds;
            //RepeaterItem.DataBind();
        }


    }
}