using LIS2017.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIS2017.Manage
{
    public partial class GeneralItemList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("../Login.aspx?link_from=Manage/GeneralItemList.aspx");
            }

            if (!IsPostBack)
            {
                InitTestType();
                InitGeneralItem();
            }
        }

        private void InitTestType()
        {
            DataSet ds = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_TYPE);
            DropDownListType.DataSource = ds;
            DropDownListType.DataTextField = "NAME";
            DropDownListType.DataValueField = "CODE";
            DropDownListType.DataBind();
        }

        private void InitGeneralItem()
        {
            int pageSize = AspNetPager1.PageSize;
            int pageNo = AspNetPager1.CurrentPageIndex - 1;
            int start = pageNo * pageSize + 1;
            int end = (pageNo + 1) * pageSize;
            string code = DropDownListType.SelectedValue;

            DataSet ds = GeneralItemManage.GetItemListByTestType(code,start,end);
            AspNetPager1.RecordCount = GeneralItemManage.GetItemListCountByTestType(code);
            AspNetPager1.CustomInfoHTML = "记录总数：<b>" + AspNetPager1.RecordCount.ToString() + "</b>";
            RepeaterItem.DataSource = ds;
            RepeaterItem.DataBind();
        }
        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AspNetPager1.CurrentPageIndex = 1;
            InitGeneralItem();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            InitGeneralItem();
        }

        protected void ImageButtonDelete_Click(object sender, ImageClickEventArgs e)
        {
            string itemCode = ((ImageButton)sender).CommandArgument;
            int i = GeneralItemManage.DeleteItemByItemCode(itemCode);
            InitGeneralItem();
        }
    }
}