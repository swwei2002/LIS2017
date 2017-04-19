using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("../Login.aspx?link_from=Manage/UserPassword.aspx");
            }
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            DataSet ds = new DataSet();
            ds = LIS2017.App_Code.Manage.UserInfo(int.Parse(Session["user_id"].ToString()));
            txtUserName.Text = ds.Tables[0].Rows[0]["user_name"].ToString();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == null || txtPasswordConfirm.Text == "")
            {
                LTP.Common.MessageBox.Show(this.Page, "密码不可为空");
                return;
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                LTP.Common.MessageBox.Show(this.Page, "密码输入不一致");
                return;
            }

            LIS2017.App_Code.Manage.UserPasswordModify(int.Parse(Session["user_id"].ToString()), txtPassword.Text);
            LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Manage/UserPassword.aspx", 0, "Success");
            ClientScript.RegisterStartupScript(this.GetType(), "false", "<script>alert('密码修改成功！');window.location.href='UserPassword.aspx'</script>");

        }
    }
}