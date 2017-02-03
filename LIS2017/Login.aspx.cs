using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                //LTP.Common.MessageBox.Show(this.Page, "用户名不可为空");
                return;
            }
            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                //LTP.Common.MessageBox.Show(this.Page, "密码不可为空");
                return;
            }
        }

    }
}