using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserDetail : System.Web.UI.Page
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
            //初始化科室
            DataSet ds = new DataSet();
            ds = LIS2017.App_Code.Common.GroupInfo("1", "0");
            ddlDepartment.DataSource = ds.Tables[0].DefaultView;
            ddlDepartment.DataTextField = "NAME";
            ddlDepartment.DataValueField = "GROUP_ID";
            ddlDepartment.DataBind();


            //初始化信息
            DataSet ds2 = new DataSet();
            ds2 = LIS2017.App_Code.Manage.UserDetail(int.Parse(Request.QueryString["user_id"]));
            txtUserId.Text = ds2.Tables[0].Rows[0]["user_id"].ToString();
            txtUserName.Text = ds2.Tables[0].Rows[0]["user_name"].ToString();
            txtPassword.Text = ds2.Tables[0].Rows[0]["user_password"].ToString();
            txtRealName.Text = ds2.Tables[0].Rows[0]["real_name"].ToString();
            ddlDepartment.SelectedValue = ds2.Tables[0].Rows[0]["department_id"].ToString();
            rblAccess.SelectedValue = ds2.Tables[0].Rows[0]["user_access"].ToString();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == null || txtUserName.Text == "")
            {
                LTP.Common.MessageBox.Show(this.Page, "用户名不可为空");
                return;
            }

            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                LTP.Common.MessageBox.Show(this.Page, "密码不可为空");
                return;
            }

            LIS2017.App_Code.Manage.UserModify(int.Parse(txtUserId.Text),txtUserName.Text,txtPassword.Text,txtRealName.Text,int.Parse(ddlDepartment.SelectedValue.ToString()),int.Parse(rblAccess.SelectedValue.ToString()));
            //LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Manage/UserDetail.aspx", int.Parse(txtUserId.Text), "ModifyUserSuccess");

            Response.Redirect("UserList.aspx");

        }
    }
}