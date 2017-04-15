using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Manage
{
    public partial class UserList : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                //Response.Redirect("/Login.aspx");
            }

            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            //ds = OA.App_Code.Manage.GetUserList();
            //gvLists.DataSource = ds;
            //gvLists.DataKeyNames = new string[] { "user_id" };
            //gvLists.DataBind();
        }


    }
}