﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Order
{
    public partial class OrderAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                //Response.Redirect("../Login.aspx?link_from=Order/OrderAdd.aspx");
            }
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            //公司
            DataSet ds = new DataSet();
            //ds = LIS2017.App_Code.Common.TypeInfoByPreId(1);
            ds = LIS2017.App_Code.Common.CompanyInfo("0");
            ddlOrderFrom.DataSource = ds.Tables[0].DefaultView;
            ddlOrderFrom.DataTextField = "NAME";
            ddlOrderFrom.DataValueField = "CODE";
            ddlOrderFrom.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" || txtNumber.Text == "" )
                {
                LTP.Common.MessageBox.Show(this.Page, "生成数量必填");
                return;
            }

            int num = LIS2017.App_Code.Order.OrderAdd(ddlOrderFrom.SelectedValue.ToString(), ddlOrderFrom.SelectedItem.Text, int.Parse(txtNumber.Text));


            LIS2017.App_Code.Common.ReviseTimeUpdate("LIS_COMPANY", "CODE", ddlOrderFrom.SelectedValue.ToString());

            //调试期间注视掉，应该没有session
            //LIS2017.App_Code.Common.AddLog(int.Parse(Session["UserId"].ToString()), "OrderAdd.aspx", num, "Add" + num + "Success");

            LTP.Common.MessageBox.Show(this.Page, "成功生成"+num+ "条标本号，请至“标本管理-项目绑定”模块绑定套餐或至“标本管理-信息补录”模块补全标本信息。");
            return;

        }
    }
}