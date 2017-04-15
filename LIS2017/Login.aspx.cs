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


            if (Request.QueryString["link_from"] == null)
            {
                Response.Redirect("MainFrame/Default.aspx");
            }
            else
            {
                Response.Redirect(Request.QueryString["link_from"]);
            }

            if (ds.Tables[0].Rows.Count == 1)
            {
                Session["user_id"] = ds.Tables[0].Rows[0]["user_id"].ToString();
                Session["user_name"] = ds.Tables[0].Rows[0]["user_name"].ToString();
                //Session["DepartmentId"] = ds.Tables[0].Rows[0]["department_id"].ToString();
                Session["real_name"] = ds.Tables[0].Rows[0]["real_name"].ToString();

                //记录cookie
                HttpCookie cookie = new HttpCookie("USER_COOKIE");
                cookie.Values.Add("user_name", txtUserName.Text.Trim());
                //cookie.Values.Add("UserPassword", txtPassword.Text.Trim());
                //这里是设置Cookie的过期时间，这里设置一个星期的时间，过了一个星期之后状态保持自动清空。   
                cookie.Expires = System.DateTime.Now.AddDays(30.0);
                HttpContext.Current.Response.Cookies.Add(cookie);


                //if (Request.ServerVariables["REMOTE_ADDR"].ToString().Length > 7)
                //{
                //    LIS2017.App_Code.Common.AddLog(txtUserName.Text, "Login.aspx", 0, "LoginSuccess");
                //}

                LTP.Common.MessageBox.Show(this.Page, "登录成功");
                return;


            }
            else
            {
                //LIS2017.App_Code.Common.AddLog(txtUserName.Text, "Login.aspx", 0, "LoginFailed");
                //LTP.Common.MessageBox.Show(this.Page, "登录失败，请核对帐号密码是否正确，或联系管理员");
                return;
            }

        }

    }
}