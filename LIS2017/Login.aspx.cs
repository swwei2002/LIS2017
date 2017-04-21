using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace LIS2017
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
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

            DataSet ds = new DataSet();
            ds =LIS2017.App_Code.Common.UserLogin(txtUserName.Text, txtPassword.Text);


            if (ds.Tables[0].Rows.Count == 1)
            {
                Session["user_id"] = ds.Tables[0].Rows[0]["user_id"].ToString();
                Session["user_name"] = ds.Tables[0].Rows[0]["user_name"].ToString();
                Session["real_name"] = ds.Tables[0].Rows[0]["real_name"].ToString();
                Session["department_id"] = ds.Tables[0].Rows[0]["real_name"].ToString();

                LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Login.aspx", 0, "Success");
            }
            else
            {
                LIS2017.App_Code.Common.AddLog(0, "Login.aspx?user_name="+txtUserName.Text, 0, "Failed");
                LTP.Common.MessageBox.Show(this.Page, "登录失败，请核对帐号密码是否正确，或联系管理员");
                return;
            }

            //成功登录后跳转页面
            if (Request.QueryString["link_from"] == null)
            {
                Response.Redirect("/Default.aspx");
            }
            else
            {
                Response.Redirect(Request.QueryString["link_from"]);
            }



        }

    }
}