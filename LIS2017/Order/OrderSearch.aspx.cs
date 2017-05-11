using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace LIS2017.Order
{
    public partial class OrderSearch : System.Web.UI.Page
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
            /*
            DataSet ds = new DataSet();

            //标本来源
            ds = LIS2017.App_Code.Common.CompanyInfo("0");
            ddlOrderFrom.DataSource = ds.Tables[0].DefaultView;
            ddlOrderFrom.DataTextField = "NAME";
            ddlOrderFrom.DataValueField = "CODE";
            ddlOrderFrom.DataBind();

            //标本类别
            ds = LIS2017.App_Code.Common.CodeInfo("C02");
            ddlSampleType.DataSource = ds.Tables[0].DefaultView;
            ddlSampleType.DataTextField = "NAME";
            ddlSampleType.DataValueField = "NAME";
            ddlSampleType.DataBind();

            //标本状态
            ds = LIS2017.App_Code.Common.DISEASEInfo();
            ddlDisease.DataSource = ds.Tables[0].DefaultView;
            ddlDisease.DataTextField = "MESSAGE";
            ddlDisease.DataValueField = "DIS_ID";
            ddlDisease.DataBind();

            //性别
            ds = LIS2017.App_Code.Common.CodeInfo("C07");
            ddlGender.DataSource = ds.Tables[0].DefaultView;
            ddlGender.DataTextField = "NAME";
            ddlGender.DataValueField = "NAME";
            ddlGender.DataBind();
            */
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = LIS2017.App_Code.Order.OrderSearch(txtCode.Text, txtName.Text, txtAge.Text, txtCardId.Text);
            rptData.DataSource = ds;
            rptData.DataBind();
        }
    }
}