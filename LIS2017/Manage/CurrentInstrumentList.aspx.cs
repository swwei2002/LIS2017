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
    public partial class CurrentInstrumentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                InitTestGroup();
                InitInstr();
            }
        }

        private void InitTestGroup()
        {
            DataSet ds = TestGroupManage.GetTestGroupByType("1");
            DropDownListTestGroup.DataSource = ds;
            DropDownListTestGroup.DataTextField = "NAME";
            DropDownListTestGroup.DataValueField = "GROUP_ID";
            DropDownListTestGroup.DataBind();

        }

        private void InitInstr()
        {
            string testGroup = DropDownListTestGroup.SelectedValue as string;
            DataSet ds = CurrentInstrumentManage.GetInstrByGroupID(testGroup);
            RepeaterInstr.DataSource = ds;
            RepeaterInstr.DataBind();
        }

        protected void DropDownListTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitInstr();
        }
    }
}