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

        }



    }
}