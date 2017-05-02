using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("../Login.aspx?link_from=Manage/UserAdd.aspx");
            }
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            DataSet ds = new DataSet();
            //ds = LIS2017.App_Code.Common.TypeInfoByPreId(1);
            ds = LIS2017.App_Code.Common.GroupInfo("1","0");
            ddlDepartment.DataSource = ds.Tables[0].DefaultView;
            ddlDepartment.DataTextField = "NAME";
            ddlDepartment.DataValueField = "GROUP_ID";
            ddlDepartment.DataBind();
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

            int new_id = LIS2017.App_Code.Manage.UserAdd(txtUserName.Text, txtPassword.Text, txtRealName.Text, int.Parse(ddlDepartment.SelectedValue.ToString()), int.Parse(rblAccess.SelectedValue.ToString()));
            LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Manage/UserAdd.aspx", new_id, "AddUserSuccess");
            Response.Redirect("UserList.aspx");


        }
    }
}