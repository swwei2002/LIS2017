using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Order
{
    public partial class OrderDetail : System.Web.UI.Page
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

            //标本信息
            ds = LIS2017.App_Code.Order.OrderDetail(int.Parse(Request.QueryString["info_id"]));
            txtCode.Text = ds.Tables[0].Rows[0]["CODE"].ToString();
            txtOrderFrom.Text = ds.Tables[0].Rows[0]["company_id"].ToString();
            ddlSampleType.SelectedValue = ds.Tables[0].Rows[0]["sample_type"].ToString();
            ddlDisease.SelectedValue = ds.Tables[0].Rows[0]["dis_code"].ToString();
            txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();
            ddlGender.SelectedValue = ds.Tables[0].Rows[0]["gender"].ToString();
            txtAge.Text = ds.Tables[0].Rows[0]["age"].ToString();
            txtCardId.Text = ds.Tables[0].Rows[0]["card_id"].ToString();
            txtSampleDate.Text = ds.Tables[0].Rows[0]["sample_date"].ToString();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string order_status = "已完善";
            if (txtName.Text == "" || txtName.Text == null)
            {
                order_status = "未完善";
            }

            //信息补录入口进入的姓名必填
            if (Request.QueryString["type"] == "complete" && order_status == "未完善")
            {
                LTP.Common.MessageBox.Show(this.Page, "补录标本信息必须填写“姓名”。");
                return;
            }

            //完善标本
            LIS2017.App_Code.Order.OrderModify(int.Parse(Request.QueryString["info_id"]), ddlOrderFrom.SelectedValue.ToString(), ddlOrderFrom.SelectedItem.Text, ddlSampleType.SelectedItem.Text, ddlDisease.SelectedValue.ToString(), ddlDisease.SelectedItem.Text, txtName.Text, ddlGender.SelectedItem.Text, txtAge.Text, txtCardId.Text, order_status);
            //修改采样日期
            LIS2017.App_Code.Order.OrderDateUpdate(int.Parse(Request.QueryString["info_id"]), "sample_date", txtSampleDate.Text);


            //将选择过的推到最前
            LIS2017.App_Code.Common.ReviseTimeUpdate("LIS_COMPANY", "CODE", ddlOrderFrom.SelectedValue.ToString());
            LIS2017.App_Code.Common.ReviseTimeUpdate("LIS_CODE_INFO","NAME",ddlSampleType.SelectedValue.ToString());
            LIS2017.App_Code.Common.ReviseTimeUpdate("LIS_DISEASE","DIS_ID",ddlDisease.SelectedValue.ToString());
            LIS2017.App_Code.Common.ReviseTimeUpdate("LIS_CODE_INFO", "NAME", ddlGender.SelectedValue.ToString());

            //暂时不记录日志，缺少session会报错
            //LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Manage/UserDetail.aspx", int.Parse(txtUserId.Text), "ModifyUserSuccess");

            Response.Redirect("OrderList.aspx");
        }
    }
}