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
    public partial class GeneralInstrumentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string instID = TextBoxInstID.Text;
            if(!IsPostBack)
            {
                InitInstrument(instID);
            }
        }

        private void InitInstrument(string instID)
        {
            int pageSize = AspNetPager1.PageSize;
            int pageNo = AspNetPager1.CurrentPageIndex - 1;
            int start = pageNo * pageSize + 1;
            int end = (pageNo + 1) * pageSize;

            DataSet ds = GeneralInstrumentManage.GetInstrumentByID(instID,start,end);
            int count = GeneralInstrumentManage.GetInstrumentCountByID(instID);
            AspNetPager1.RecordCount = count;
            AspNetPager1.CustomInfoHTML = "记录总数：<b>" + AspNetPager1.RecordCount.ToString() + "</b>";

            RepeaterInstr.DataSource = ds;
            RepeaterInstr.DataBind();
        }

        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            string instID = TextBoxInstID.Text;
            AspNetPager1.CurrentPageIndex = 1;
            InitInstrument(instID);
        }

        protected void ImageButtonDelete_Click(object sender, ImageClickEventArgs e)
        {
            string instID = TextBoxInstID.Text;
            string type = ((ImageButton)sender).CommandArgument;
            int i = GeneralInstrumentManage.DeleteInstrByType(type);
            InitInstrument(instID);
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            string instID = TextBoxInstID.Text;
            InitInstrument(instID);
        }
    }
}