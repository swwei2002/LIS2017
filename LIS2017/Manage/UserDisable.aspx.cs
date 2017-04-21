using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserDisable : System.Web.UI.Page
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
            //更新
            LIS2017.App_Code.Manage.UserDisable(int.Parse(Request.QueryString["user_id"]), int.Parse(Request.QueryString["disable"]));
            //日志
            LIS2017.App_Code.Common.AddLog(int.Parse(Session["user_id"].ToString()), "Manage/UserDisable.aspx", int.Parse(Request.QueryString["user_id"]), "DisableSuccess");
            //跳转
            Response.Redirect("UserList.aspx");

        }
    }
}