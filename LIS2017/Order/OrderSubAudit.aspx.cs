using LIS2017.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIS2017.Order
{
    public partial class OrderSubAudit : System.Web.UI.Page
    {
        protected int _userID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //_userID = (int)Session["user_id"];

            _userID = 2;

            if(!IsPostBack)
            {
                InitOrderSub(_userID);
            }
        }

        private void InitOrderSub(int uID)
        {
            DataSet ids = OrderSubManage.GetUnAuditOrderIDByUserID(uID);
            DataSet subs = OrderSubManage.GetUnAuditByUserID(uID);
            foreach(DataRow id in ids.Tables[0].Rows)
            {
                string orderID = id["ORDER_ID"] as string;
                DataRow[] user_subs = subs.Tables[0].Select("ORDER_ID='" + orderID + "'");
                TreeNode tr = new TreeNode(orderID);
                tr.SelectAction = TreeNodeSelectAction.None;
                tr.ShowCheckBox = true;
                tr.Value = orderID;
                foreach(DataRow dr in user_subs)
                {
                    string name = dr["NAME"] as string;
                    string shortName = dr["SHORTNAME"] as string;
                    TreeNode t = new TreeNode();
                    t.SelectAction = TreeNodeSelectAction.None;
                    t.Text = shortName + "-" + name;
                    tr.ChildNodes.Add(t);
                }
                TreeViewOrderSub.Nodes.Add(tr);
            }
        }

        protected void ButtonAudit_Click(object sender, EventArgs e)
        {
            TreeNodeCollection subs = TreeViewOrderSub.CheckedNodes;
            foreach(TreeNode tn in subs)
            {
                string orderID = tn.Value;
                int res = OrderSubManage.UpdateAuditFlg(_userID, orderID);
            }

            Response.Redirect("ItemResultInput.aspx");
        }

        protected void ButtonSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("ItemResultInput.aspx");
        }
    }
}